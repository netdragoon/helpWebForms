# Canducci Mvc Helpers

[![NuGet](https://img.shields.io/nuget/v/CanducciHtmlMvcHelpers.svg?style=plastic&label=version)](https://www.nuget.org/packages/CanducciHtmlMvcHelpers/)

###Button Simply or Bootstrap Style

    @Html.ButtonSubmit("Normal")

    @Html.ButtonSubmit("Default", ButtonBootstrapStyle.Default)
    @Html.ButtonSubmit("Primary", ButtonBootstrapStyle.Primary)
    @Html.ButtonSubmit("Success", ButtonBootstrapStyle.Success)
    @Html.ButtonSubmit("Info", ButtonBootstrapStyle.Info)
    @Html.ButtonSubmit("Warning", ButtonBootstrapStyle.Warning)
    @Html.ButtonSubmit("Danger", ButtonBootstrapStyle.Danger)
    @Html.ButtonSubmit("Link", ButtonBootstrapStyle.Link)

    @Html.ButtonSubmit("Default", ButtonBootstrapStyle.Default, Glyphicon.Ok)
    @Html.ButtonSubmit("Primary", ButtonBootstrapStyle.Primary, Glyphicon.Ok)
    @Html.ButtonSubmit("Success", ButtonBootstrapStyle.Success, Glyphicon.Pause)
    @Html.ButtonSubmit("Info", ButtonBootstrapStyle.Info, Glyphicon.Ok)
    @Html.ButtonSubmit("Warning", ButtonBootstrapStyle.Warning, Glyphicon.Ok)
    @Html.ButtonSubmit("Danger", ButtonBootstrapStyle.Danger, Glyphicon.Ok)
    @Html.ButtonSubmit("Link", ButtonBootstrapStyle.Link, Glyphicon.Ok)


###RadioButtonList


##NUGET

```Csharp
PM> Install-Package CanducciHtmlMvcHelpers

```

##How to?

__Code__
```Csharp
[HttpGet()]
public async Task<ActionResult> Edit(int? id = 1)
{
    Options model = await db.Options.FindAsync(id.Value);
    ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", model.SelectId);
    return View(model);
}

[HttpPost()]
public async Task<ActionResult> Edit(Options option)
{
    db.Entry(option).State = System.Data.Entity.EntityState.Modified;
    await db.SaveChangesAsync();
    ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", option.SelectId);
    return RedirectToAction("Edit", new { id = option.OptionId });
}
```

__View?__
```Csharp
@model WebApplication2.Models.Options
@{ Layout = null; }
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Edit</title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-1.10.2.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/respond.js"></script>
</head>
<body>
    @using (Html.BeginForm())
    {
        @Html.AntiForgeryToken()
        
        <div class="form-horizontal">
            <h4>Options</h4>
            <hr />
            @Html.ValidationSummary(true, "", new { @class = "text-danger" })
            <div class="form-group">
                @Html.LabelFor(model => model.OptionId, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(model => model.OptionId, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.OptionId, "", new { @class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(model => model.SelectId, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.RadioButtonListFor(model => model.SelectId, ViewData["Status"] as RadioButtonList, null, "<div class=\"checkbox\">")
                    @Html.ValidationMessageFor(model => model.SelectId, "", new { @class = "text-danger" })
                </div>
            </div>
    
            <div class="form-group">
                @Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" })
                <div class="col-md-10">
                    @Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } })
                    @Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" })
                </div>
            </div>    
            <div class="form-group">
                <div class="col-md-offset-2 col-md-10">
                    <input type="submit" value="Save" class="btn btn-default" />
                </div>
            </div>
        </div>
    }
</body>
</html>
```
__Observe Here!!!__
```Csharp
 @Html.RadioButtonListFor(model => model.SelectId, ViewData["Status"] as RadioButtonList, null, "<div class=\"checkbox\">")
                    @Html.ValidationMessageFor(model => model.SelectId, "", new { @class = "text-danger" })
```
###Or

__Code__
```Csharp
[HttpGet()]
public ActionResult Index()
{
    var id = (db.Selecting.Where(c => c.Status == true).FirstOrDefault().SelectId);
    ViewData["Status"] = RadioButtonList.Create(db.Selecting.ToList(), "SelectId", "Name", id);
    return View(db.Selecting.OrderBy(c => c.SelectId).ToArray());
}
```
__View?__
```Csharp
@{ Layout = null; }
<!DOCTYPE html>
<html>
<head>
    <meta name="viewport" content="width=device-width" />
    <title>Index</title>
    <link href="~/Content/bootstrap.min.css" rel="stylesheet" />
    <script src="~/Scripts/jquery-1.10.2.js"></script>
    <script src="~/Scripts/bootstrap.js"></script>
    <script src="~/Scripts/respond.js"></script>
</head>
<body>
    @using (Html.BeginForm())
    {
        <div>
            @Html.RadioButtonList("Status") 
        </div>
        <div>
            <button type="submit">Alterar</button>
        </div>
    }
</body>
</html>
```
___

__Result__

[![Result](http://i1308.photobucket.com/albums/s610/maryjanexique/ave-ave_zpsp1qs0wah.png)](https://www.nuget.org/packages/CanducciHtmlMvcHelpers/)

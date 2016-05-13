# RadioButtonList

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

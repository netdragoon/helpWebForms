Imports System.IO

Public Class Form1

    Dim ListItems As New List(Of Items)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LerXml()

        'Carregar o Combo
        ComboBox1.Items.AddRange(ListItems.Select(Function(a) a.Key).ToArray())




        Dim Item1 As ListViewItem = ListView1.Columns(0).ListView.Items.Add("Fulvio")
        Item1.Text = "Fulvio"
        Item1.SubItems.Add("12345")

        ListView1.Columns(1).Width = 0
        ListView1.Columns(1).AutoResize(ColumnHeaderAutoResizeStyle.None)


        Dim Item2 As ListViewItem = ListView1.Columns(1).ListView.Items.Add("Hugo")
        Item2.Text = "Hugo"
        Item2.SubItems.Add("12345")

    End Sub

    Private Sub ListView1_ColumnWidthChanging(sender As Object, e As ColumnWidthChangingEventArgs) Handles ListView1.ColumnWidthChanging

        If (e.ColumnIndex = 1) Then
            e.NewWidth = 0
            e.Cancel = True
        End If

    End Sub


    Sub LerXml()
        Dim xmlText As String = File.ReadAllText(".\Base.xml")
        Dim results = (From c In XDocument.Parse(xmlText).Descendants("Items").Elements()
                       Select New With
                         {
                            .Name = c.Attribute("text").Value,
                            .Items = c.Elements("subItem").Attributes("text").Select(Function(a) a.Value).ToList()
                         }).ToArray()

        For Each result In results
            ListItems.Add(New Items(result.Name, result.Items))
        Next

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If (ComboBox1.Items.Count > 0) Then
            Dim strs As String() = ListItems.Where(Function(c) c.Key.Equals(ComboBox1.SelectedItem)).Select(Function(a) a.Items).FirstOrDefault().ToArray()
            If (IsNothing(strs) = False) Then
                TextBox1.Text = strs(0)
                TextBox2.Text = strs(1)
                TextBox3.Text = strs(2)
                TextBox4.Text = strs(3)
            End If

        End If
    End Sub
End Class

Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class Form1

    Private Sub TXTButton_Click(sender As Object, e As EventArgs) Handles TXTButton.Click
        Dim writer As System.IO.StreamWriter
        writer = My.Computer.FileSystem.OpenTextFileWriter("C:\WriteFile\TXTButton.txt", True)
        writer.WriteLine("Name: " & NameBox.Text)
        writer.WriteLine("Age: " & AgeBox.Text)
        writer.WriteLine("Address: " & AddressBox.Text)
        writer.Close()
         MessageBox.Show("TXT file saved. (C:\WriteFile\TXTButton.txt)")
    End Sub

    Private Sub XMLButton_Click(sender As Object, e As EventArgs) Handles XMLButton.Click
        Dim writer As New XmlTextWriter("c:\WriteFile\XMLButton.xml", System.Text.Encoding.UTF8)

        writer.WriteStartDocument(True)
        writer.Formatting = Xml.Formatting.Indented
        writer.Indentation = 2
        writer.WriteStartElement("WriteToXML")
        createNode(NameBox.Text, AgeBox.Text, AddressBox.Text, writer)
        writer.WriteEndElement()
        writer.WriteEndDocument()
        writer.Close()
        MessageBox.Show("XML file saved. (C:\WriteFile\XMLButton.xml)")
    End Sub
    Private Sub createNode(ByVal dName As String, ByVal dAge As String, ByVal dAddress As String, ByVal writer As XmlTextWriter)
        writer.WriteStartElement("Details")
        writer.WriteStartElement("Name")
        writer.WriteString(dName)
        writer.WriteEndElement()
        writer.WriteStartElement("Age")
        writer.WriteString(dAge)
        writer.WriteEndElement()
        writer.WriteStartElement("Address")
        writer.WriteString(dAddress)
        writer.WriteEndElement()
        writer.WriteEndElement()
    End Sub

    Private Sub JSONButton_Click(sender As Object, e As EventArgs) Handles JSONButton.Click

        Dim data As New Detail()
        data.Name = NameBox.Text
        data.Age = AgeBox.Text
        data.Address = AddressBox.Text

        Dim json As String = JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented)
        Dim file As IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter("C:\WriteFile\JSONButton.json", True)
        file.WriteLine(json)
        file.Close()
        MessageBox.Show("JSON file saved. (C:\WriteFile\JSONButton.json)")
    End Sub




End Class

Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Public Class penjualan
    Private Sub penjualan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub
    Private Sub Reloaded()
        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(penjualan_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of classPenjualan) = JsonConvert.DeserializeObject(Of List(Of classPenjualan))(response)

        ' Bind the data to the DataGridView
        dgvData2.DataSource = data
    End Sub
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If (penjualan_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If
    End Sub
    Private Sub TambahData()
        ' Set the data you want to send as key-value pairs
        Dim kodeJual As String = txtKodeJual.Text
        Dim kodeObat As String = txtKode.Text
        Dim namaObat As String = txtNama.Text
        Dim harga As String = txtHarga.Text

        Dim postData As String = $"kodeJual={kodeJual}&kodeObat={kodeObat}&namaObat={namaObat}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(penjualan_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub
    Private Sub UpdateData()
        ' Set the data you want to send as key-value pairs
        Dim kodeJual As String = txtKodeJual.Text
        Dim kodeObat As String = txtKode.Text
        Dim namaObat As String = txtNama.Text
        Dim harga As String = txtHarga.Text

        Dim postData As String = $"kodeJual={kodeJual}&kodeObat={kodeObat}&namaObat={namaObat}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(penjualan_api & "?kodeJual=" & txtKodeJual.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub
    Private Sub DeleteData()
        ' Set the data you want to send as key-value pairs
        Dim kodeJual As String = txtKodeJual.Text
        Dim kodeObat As String = txtKode.Text
        Dim namaObat As String = txtNama.Text
        Dim harga As String = txtHarga.Text

        Dim postData As String = $"kodeJual={kodeJual}&kodeObat={kodeObat}&namaObat={namaObat}&harga={harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(penjualan_api & "?kodeJual=" & txtKodeJual.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub
    Private Sub txtKodeJual_KeyDown(sender As Object, e As KeyEventArgs) Handles txtKodeJual.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub
    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(penjualan_api & "?kodeJual=" & txtKodeJual.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result

                If (jsonString = "[]") Then
                    penjualan_baru = True
                    MessageBox.Show("Data Not Found")

                Else

                    penjualan_baru = False
                    ' Deserialize the JSON into objects
                    Dim data As List(Of classPenjualan) = JsonConvert.DeserializeObject(Of List(Of classPenjualan))(jsonString)

                    ' Create textboxes dynamically and set their values
                    For Each mydata As classPenjualan In data
                        txtKodeJual.Text = mydata.kodeJual
                        txtKode.Text = mydata.kodeObat
                        txtNama.Text = mydata.namaObat
                        txtHarga.Text = mydata.harga

                    Next

                End If

            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (penjualan_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub
    Private Sub GetClear()
        txtKodeJual.Clear()
        txtKode.Clear()
        txtNama.Clear()
        txtHarga.Clear()
    End Sub
End Class
Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Public Class login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        SignIn()
    End Sub
    Private Sub SignIn()

        ' Set the data you want to send as key-value pairs
        Dim user As String = txtUsername.Text
        Dim passwd As String = txtPassword.Text


        Dim postData As String = $"username={user}&passwd={passwd}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(users_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)
            Dim responseObject As JObject = JObject.Parse(responseBody)
            ' Access the "status" property
            Dim status As String = responseObject("status").ToString()

            ' Access the "message" property
            Dim message As String = responseObject("message").ToString()
            ' Display the response
            MessageBox.Show(responseBody, "Response")
            'MessageBox.Show(status)
            'MessageBox.Show(message)
            If (message = "admin") Then
                admin_role = True
                login_valid = True
            Else
                admin_role = False
                MessageBox.Show("User tidak dikenal", "Error")
                login_valid = False
            End If
            If (login_valid = True) Then
                Dim Dashboard As New dashboard
                Dashboard.Show()
                Me.Hide()

            End If

        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try

    End Sub
End Class
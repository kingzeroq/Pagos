Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Services
Imports Google.Apis.Sheets.v4
Imports Google.Apis.Sheets.v4.Data
Imports Google.Apis.Util.Store
Imports System.IO
Imports System.Threading

Public Class Form1
    ' Variables de credenciales
    Private ReadOnly credentialFilePath As String = "C:\Users\danie\OneDrive\Escritorio\programacion 3\pagos-436715-cba82996c247.json"
    Private service As SheetsService

    ' Declarar constantes como campos Static ReadOnly
    Private Shared ReadOnly meses As String() = New String() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"}
    Private Shared ReadOnly estados As String() = New String() {"Pago", "No Pago"}

    ' Método para inicializar el servicio de Google Sheets
    Private Sub InitializeService()
        Dim credential As GoogleCredential
        Using stream = New FileStream(credentialFilePath, FileMode.Open, FileAccess.Read)
            credential = GoogleCredential.FromStream(stream).CreateScoped(SheetsService.Scope.Spreadsheets)
        End Using

        service = New SheetsService(New BaseClientService.Initializer() With {
            .HttpClientInitializer = credential,
            .ApplicationName = "Aplicación Pagos"
        })
    End Sub

    ' Método para guardar datos en Google Sheets
    Private Sub GuardarDatosEnGoogleSheets()
        Dim nombre As String = TxtNombre.Text
        Dim numeroCasa As String = TxtNumero.Text
        Dim mes As String = Cpagos.SelectedItem.ToString() ' ComboBox de meses
        Dim estado As String = Cpagos.SelectedItem.ToString() ' Cambiar a Cpagos para que tome el estado

        ' Verificar campos
        If String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(numeroCasa) Or String.IsNullOrWhiteSpace(mes) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        ' Obtener la ID de la hoja según el mes
        Dim spreadsheetId As String = "1QE9DEZtOCLzr9we18hkw3s3ilX4cyrdnnoa1Tqus4x8" ' ID de la hoja de cálculo
        Dim range As String = $"{mes}!A:C" ' Rango de columnas a guardar

        ' Obtener los valores actuales
        Dim request As SpreadsheetsResource.ValuesResource.GetRequest = service.Spreadsheets.Values.Get(spreadsheetId, range)
        Dim response As ValueRange = request.Execute()
        Dim values As IList(Of IList(Of Object)) = response.Values

        ' Agregar nuevos datos
        If values Is Nothing OrElse values.Count = 0 Then
            values = New List(Of IList(Of Object))()
        End If
        values.Add(New List(Of Object) From {nombre, numeroCasa, estado})

        ' Actualizar la hoja
        Dim updateRequest = New SpreadsheetsResource.ValuesResource.UpdateRequest(service, New ValueRange With {
            .Values = values,
            .MajorDimension = "ROWS"
        }, spreadsheetId, range)

        updateRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.UpdateRequest.ValueInputOptionEnum.USERENTERED
        updateRequest.Execute()

        MessageBox.Show("Datos guardados exitosamente.")
    End Sub

    ' Evento de clic del botón de guardar
    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        GuardarDatosEnGoogleSheets()
    End Sub

    ' Evento de clic del botón de Excel
    Private Sub BExcel_Click(sender As Object, e As EventArgs) Handles BExcel.Click
        Try
            Dim url As String = "https://sheets.google.com"
            Dim processInfo As New ProcessStartInfo(url) With {
                .UseShellExecute = True ' Asegura que se abra en el navegador
            }
            Process.Start(processInfo)
        Catch ex As Exception
            MessageBox.Show($"Error al abrir Google Sheets: {ex.Message}")
        End Try
    End Sub

    ' Evento de clic del botón Agregar (para agregar los datos al ListBox)
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim nombre As String = TxtNombre.Text
        Dim numeroCasa As String = TxtNumero.Text
        Dim mes As String = Cpagos.SelectedItem?.ToString() ' ComboBox de meses
        Dim estado As String = Cpagos.SelectedItem?.ToString() ' Cambiar a Cpagos para que tome el estado

        ' Verificar campos
        If String.IsNullOrWhiteSpace(nombre) Or String.IsNullOrWhiteSpace(numeroCasa) Or String.IsNullOrWhiteSpace(mes) Or String.IsNullOrWhiteSpace(estado) Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Return
        End If

        ' Agregar los datos al ListBox
        ListBox1.Items.Add($"Nombre: {nombre}, Casa: {numeroCasa}, Mes: {mes}, Estado: {estado}")
    End Sub

    ' Evento de carga del formulario
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeService()

        ' Inicializar ComboBox de meses y estados
        Cpagos.Items.AddRange(meses)
        Cpagos.Items.AddRange(estados) ' Cargamos opciones de estado
    End Sub

    ' Validar que TxtNumero solo acepte números
    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class

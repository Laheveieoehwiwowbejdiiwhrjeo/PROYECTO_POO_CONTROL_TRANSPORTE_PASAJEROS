Imports System.Data.SqlClient
Imports System.Text

Public Class Procesos_form2

    Inherits System.Windows.Forms.Form 'FORMULARION EN VENTANA
    Dim Cn As New SqlConnection("Data Source=.;Initial Catalog=CONTROL_DE_PASAJEROS;Integrated Security=True") 'ES PARA CONEXCION Y CONEXION SQL ORIGEN DE DATOS
    Private cmd As New SqlCommand("", Cn) 'COMANDOS DE SQL COMO CONSULTAS
    Private stb As New StringBuilder() '  PARA UN CADENA 
    Private adaptador As SqlDataAdapter 'ES PARA HACER CONSULTAS, SE UTILISA PARA HACER REFERENCIA
    Private data As DataSet 'UBICAR LOS REGISTROS
    Private Fila As Integer '
    Public reg, I As Integer '
    Dim dvw As New DataView 'PARA ENVIAR A EMPRESORA DATA 
    Private pc As String 'VARIABLE DE TIPO CADENA
    Sub CONTROLA()
        data = New DataSet()
        Cn.Open()
        adaptador.Fill(data, "EMPLEADOS")
        Cn.Close()
    End Sub

    Sub principal()

        Dim Cmd As New SqlCommand("select getdate()", Cn) 'SELECIONAR LECTUAL ACTUAL
        adaptador = New SqlDataAdapter("SELECT * FROM REPOR_PASAJERO", Cn) 'HACER CONEXION A LA TABLA , Y SELECIONAR TODO DE LA TABLA EMPLEADOS
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        CONTROLA()
        dvw = data.Tables(0).DefaultView()
        Dim X As Control
        For Each X In Controls
            If TypeOf X Is TextBox Then
                X.Text = ""
            End If
        Next
    End Sub

    ''' <summary>
    ''' VARIABLES NECESARIOS
    ''' </summary>
    ''' <param name="txtNum_boleta"></param>
    ''' <param name="txtResponsable"></param>
    ''' <param name="txtFec_Emisi"></param>
    ''' <param name="txtNombre"></param>
    ''' <param name="txtRuc"></param>
    ''' <param name="txtDni"></param>
    ''' <param name="txtTelf"></param>
    ''' <param name="txtCel"></param>
    Public Sub numeros(ByVal num_asiento As Integer, ByVal txtNum_boleta As TextBox, ByVal txtNombre As TextBox, ByVal txtDni As TextBox, ByVal txtRuc As TextBox, ByVal txtedad As TextBox, ByVal txtTelf As TextBox, ByVal txtCel As TextBox,
                      ByVal txtResponsable As TextBox, ByVal txtFec_Emisi As TextBox, ByVal txtPrecio As TextBox)
        Dim Cmd As New SqlCommand("select getdate()", Cn) 'SELECIONAR LECTUAL ACTUAL
        adaptador = New SqlDataAdapter("SELECT * FROM REPOR_PASAJERO", Cn) 'HACER CONEXION A LA TABLA , Y SELECIONAR TODO DE LA TABLA EMPLEADOS
        Dim oCommBuild As SqlCommandBuilder = New SqlCommandBuilder(adaptador)
        CONTROLA()
        'TODOS LOS QUE SON TEXTBOX
        Dim oDataRow As DataRow
        oDataRow = data.Tables("REPOR_PASAJERO").Rows(num_asiento)
        txtNum_boleta.Text = oDataRow("COD_BOLETO")
        txtNombre.Text = oDataRow("NOMBRE_APELLIDOS")
        txtDni.Text = oDataRow("DNI")
        txtRuc.Text = oDataRow("RUC")
        txtedad.Text = oDataRow("FECHA_NACIMIENTO")
        txtTelf.Text = oDataRow("TELEFONO")
        txtCel.Text = oDataRow("CELULAR")
        txtResponsable.Text = oDataRow("NOMBRES")
        txtFec_Emisi.Text = oDataRow("FECH_EMISION")
        txtPrecio.Text = oDataRow("BOLE_PRECIO")

    End Sub

End Class

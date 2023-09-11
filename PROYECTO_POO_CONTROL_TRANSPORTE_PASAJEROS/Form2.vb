Imports System.Data 'PARA TRABAJAR CON DATOS 
Imports System.Data.SqlClient 'LOS TADOS PROBIENES EN UN NCLIENTE SQL
Imports System.Text 'DATOS TIPO TEXTO
Imports System.IO 'ENTRA Y SALIDA
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox
Imports System.Net
Imports System.Runtime.InteropServices

Public Class Form2
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

    Private n_asiento As Integer 'para indicar el asiento actual

    Private P As New Procesos_form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNro_Doc.Enabled = False

    End Sub

  
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim resultado As DialogResult
        resultado = MessageBox.Show("¿Desea continuar?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If resultado = DialogResult.Yes Then
            Select Case n_asiento
                Case 1
                    b_1.BackColor = lbl_red.BackColor
                Case 2
                    b_2.BackColor = lbl_red.BackColor
                Case 3
                    b_3.BackColor = lbl_red.BackColor
                Case 4
                    b_4.BackColor = lbl_red.BackColor
                Case 5
                    b_5.BackColor = lbl_red.BackColor
                Case 6
                    b_6.BackColor = lbl_red.BackColor
                Case 7
                    b_7.BackColor = lbl_red.BackColor
                Case 8
                    b_8.BackColor = lbl_red.BackColor
                Case 9
                    b_9.BackColor = lbl_red.BackColor
                Case 10
                    b_10.BackColor = lbl_red.BackColor
                Case 11
                    b_11.BackColor = lbl_red.BackColor
                Case 12
                    b_12.BackColor = lbl_red.BackColor
                Case 13
                    b_13.BackColor = lbl_red.BackColor
                Case 14
                    b_14.BackColor = lbl_red.BackColor
                Case 15
                    b_15.BackColor = lbl_red.BackColor
                Case 16
                    b_16.BackColor = lbl_red.BackColor
                Case 17
                    b_17.BackColor = lbl_red.BackColor
                Case 18
                    b_18.BackColor = lbl_red.BackColor
                Case 19
                    b_19.BackColor = lbl_red.BackColor
                Case 20
                    b_20.BackColor = lbl_red.BackColor
                Case 21
                    b_21.BackColor = lbl_red.BackColor
                Case 22
                    b_22.BackColor = lbl_red.BackColor
                Case 23
                    b_1.BackColor = lbl_red.BackColor
                Case 24
                    b_24.BackColor = lbl_red.BackColor
                Case 25
                    b_25.BackColor = lbl_red.BackColor
                Case 26
                    b_26.BackColor = lbl_red.BackColor
                Case 27
                    b_27.BackColor = lbl_red.BackColor
                Case 28
                    b_28.BackColor = lbl_red.BackColor
                Case 29
                    b_29.BackColor = lbl_red.BackColor
                Case 30
                    b_30.BackColor = lbl_red.BackColor
                Case 31
                    b_31.BackColor = lbl_red.BackColor
                Case 32
                    b_32.BackColor = lbl_red.BackColor
                Case 33
                    b_33.BackColor = lbl_red.BackColor
                Case 34
                    b_34.BackColor = lbl_red.BackColor
                Case 35
                    b_35.BackColor = lbl_red.BackColor
                Case 36
                    b_36.BackColor = lbl_red.BackColor
                Case 37
                    b_37.BackColor = lbl_red.BackColor
                Case 38
                    b_38.BackColor = lbl_red.BackColor
                Case 39
                    b_39.BackColor = lbl_red.BackColor
                Case 40
                    b_40.BackColor = lbl_red.BackColor
            End Select
        ElseIf resultado = DialogResult.No Then
            MessageBox.Show("gracias")
        End If

    End Sub

    Private Sub b_2_Click(sender As Object, e As EventArgs) Handles b_2.Click
        n_asiento = 2
        lblNumeroDeAsiento.Text = n_asiento
        P.numeros(n_asiento, txtNUM_BOLETA, txtNombre, txtDni, txtRuc, txtEdad, txtTelf, txtCel, txtResponsable, txtFech_emi, txtPrecio)
    End Sub

    Private Sub b_3_Click(sender As Object, e As EventArgs) Handles b_3.Click
        n_asiento = 3
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_4_Click(sender As Object, e As EventArgs) Handles b_4.Click
        n_asiento = 4
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_5_Click(sender As Object, e As EventArgs) Handles b_5.Click
        n_asiento = 5
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_6_Click(sender As Object, e As EventArgs) Handles b_6.Click
        n_asiento = 6
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_7_Click(sender As Object, e As EventArgs) Handles b_7.Click
        n_asiento = 7
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_8_Click(sender As Object, e As EventArgs) Handles b_8.Click
        n_asiento = 8
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_9_Click(sender As Object, e As EventArgs) Handles b_9.Click
        n_asiento = 9
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_10_Click(sender As Object, e As EventArgs) Handles b_10.Click
        n_asiento = 10
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_11_Click(sender As Object, e As EventArgs) Handles b_11.Click
        n_asiento = 11
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_12_Click(sender As Object, e As EventArgs) Handles b_12.Click
        n_asiento = 12
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_13_Click(sender As Object, e As EventArgs) Handles b_13.Click
        n_asiento = 13
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_14_Click(sender As Object, e As EventArgs) Handles b_14.Click
        n_asiento = 14
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_15_Click(sender As Object, e As EventArgs) Handles b_15.Click
        n_asiento = 15
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_16_Click(sender As Object, e As EventArgs) Handles b_16.Click
        n_asiento = 16
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_17_Click(sender As Object, e As EventArgs) Handles b_17.Click
        n_asiento = 17
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_18_Click(sender As Object, e As EventArgs) Handles b_18.Click
        n_asiento = 18
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_19_Click(sender As Object, e As EventArgs) Handles b_19.Click
        n_asiento = 19
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_20_Click(sender As Object, e As EventArgs) Handles b_20.Click
        n_asiento = 20
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_21_Click(sender As Object, e As EventArgs) Handles b_21.Click
        n_asiento = 21
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_22_Click(sender As Object, e As EventArgs) Handles b_22.Click
        n_asiento = 22
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_23_Click(sender As Object, e As EventArgs) Handles b_23.Click
        n_asiento = 23
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_24_Click(sender As Object, e As EventArgs) Handles b_24.Click
        n_asiento = 24
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_25_Click(sender As Object, e As EventArgs) Handles b_25.Click
        n_asiento = 25
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_26_Click(sender As Object, e As EventArgs) Handles b_26.Click
        n_asiento = 26
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_27_Click(sender As Object, e As EventArgs) Handles b_27.Click
        n_asiento = 27
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_28_Click(sender As Object, e As EventArgs) Handles b_28.Click
        n_asiento = 28
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_29_Click(sender As Object, e As EventArgs) Handles b_29.Click
        n_asiento = 29
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_30_Click(sender As Object, e As EventArgs) Handles b_30.Click
        n_asiento = 30
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_31_Click(sender As Object, e As EventArgs) Handles b_31.Click
        n_asiento = 31
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_32_Click(sender As Object, e As EventArgs) Handles b_32.Click
        n_asiento = 32
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_33_Click(sender As Object, e As EventArgs) Handles b_33.Click
        n_asiento = 33
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_34_Click(sender As Object, e As EventArgs) Handles b_34.Click
        n_asiento = 34
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_35_Click(sender As Object, e As EventArgs) Handles b_35.Click
        n_asiento = 35
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_36_Click(sender As Object, e As EventArgs) Handles b_36.Click
        n_asiento = 36
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_37_Click(sender As Object, e As EventArgs) Handles b_37.Click
        n_asiento = 37
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_38_Click(sender As Object, e As EventArgs) Handles b_38.Click
        n_asiento = 38
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_39_Click(sender As Object, e As EventArgs) Handles b_39.Click
        n_asiento = 39
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_40_Click(sender As Object, e As EventArgs) Handles b_40.Click
        n_asiento = 40
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub b_1_Click(sender As Object, e As EventArgs) Handles b_1.Click
        n_asiento = 1
        lblNumeroDeAsiento.Text = n_asiento
    End Sub

    Private Sub cmbTipDoc_GotFocus(sender As Object, e As EventArgs) Handles cmbTipDoc.GotFocus
        cmbTipDoc.Items.Clear()
        cmbTipDoc.Items.Add("DNI")
        cmbTipDoc.Items.Add("CARNET")
        cmbTipDoc.Items.Add("PASAPORTE")
    End Sub

    Private Sub cmbTipDoc_Click(sender As Object, e As EventArgs) Handles cmbTipDoc.Click
        txtNro_Doc.Enabled = True
    End Sub
End Class
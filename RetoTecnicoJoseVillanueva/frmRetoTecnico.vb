Imports System.Data.SqlClient

Public Class frmRetoTecnico
    Inherits System.Windows.Forms.Form

    'Create ADO.NET objects
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader
    Private results As String

    Dim dTipoCambio As Decimal
    Dim dPagoFijo As Decimal
    Dim dPagoTemporal As Decimal

    Dim i, j As Integer
    Dim iIncremento As Integer

    Dim iFechaItem As Integer
    Dim iFechaInicial As Integer
    Dim iFechaFinal As Integer

    Dim sValor As String
    Dim sNombre As String

    Dim iColumnas As Integer = 7
    Dim iPersonas As Integer = 100
    Dim aTrabajadores(iPersonas, iColumnas) As String 'Array

    Dim bProcesoTrabajador As Boolean
    Dim bProcesoModalidad As Boolean
    Dim bProcesoHoras As Boolean

    Dim dtToday As Date
    Dim sDia, sMes, sAno As String

    'BLOQUE INICIO
    Private Sub frmRetoTecnico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Variables Iniciales
        dTipoCambio = 3.95

        dPagoFijo = 9.23
        dPagoTemporal = 14.87

        iFechaInicial = 20220101
        iFechaFinal = 20221231


        'Create a Connection object
        'myConn = New SqlConnection("Data Source=LAP-5CG12317YM\SQLEXPRESS;User ID=jose;Password=N0v13mbr32022.;")
        myConn = New SqlConnection("Data Source=LAP-5CG12317YM\SQLEXPRESS;Initial Catalog=RetoTecnico;Integrated Security=True")

        'Open the connection
        myConn.Open()

        'Create a Command object
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT Id, Fecha, NombreApellido, Modalidad, Horas, TipoCambio, PagoSoles, PagoDolares FROM Trabajadores"
        myReader = myCmd.ExecuteReader()

        'Concatenate the query result into a string
        iIncremento = 0

        Do While myReader.Read()
            'results = results & myReader.GetString(0) & vbTab & myReader.GetString(1) & vbLf
            'MsgBox(myReader.GetString(2))

            'Cargar Trabajador
            aTrabajadores(iIncremento, 0) = myReader.GetString(1).Trim()
            aTrabajadores(iIncremento, 1) = myReader.GetString(2).Trim()
            aTrabajadores(iIncremento, 2) = myReader.GetString(3).Trim()

            aTrabajadores(iIncremento, 3) = myReader.GetInt32(4).ToString().Trim()

            aTrabajadores(iIncremento, 4) = myReader.GetDecimal(5).ToString().Trim()
            aTrabajadores(iIncremento, 5) = myReader.GetDecimal(6).ToString().Trim()
            aTrabajadores(iIncremento, 6) = myReader.GetDecimal(7).ToString().Trim()

            iIncremento += 1
        Loop

        'Display results
        'MsgBox(results)

        'Close the reader and the database connection
        myReader.Close()
        myConn.Close()


        'Cargar Indicaciones al Inicio
        With gbxAcercaDe
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With

    End Sub
    'BLOQUE INICIO

    'BLOQUE PROCEDIMIENTOS Y FUNCIONES
    Private Sub CerrarVentanas()
        gbxAcercaDe.Visible = False
        gbxTipoCambio.Visible = False
        gbxTipoPago.Visible = False
        gbxListaTrabajadores.Visible = False
        gbxNominaTrabajadores.Visible = False
        gbxAgregarTrabajador.Visible = False
    End Sub
    'BLOQUE PROCEDIMIENTOS Y FUNCIONES

    'BLOQUE MENU
    Private Sub AgregarTrabajadorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarTrabajadorToolStripMenuItem.Click
        CerrarVentanas()

        With gbxAgregarTrabajador
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With

        cbxAgregarModalidad.SelectedIndex = 0
        txtAgregarNombreApellidos.Focus()
    End Sub

    Private Sub ListaDeTrabajadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaDeTrabajadoresToolStripMenuItem.Click
        CerrarVentanas()

        iIncremento = 0
        dgvTrabajadores.Rows.Clear()

        For i = 0 To iPersonas - 1
            sValor = aTrabajadores(i, 0)

            If (IsNothing(sValor)) Then
                Exit For
            Else
                iFechaItem = Integer.Parse(aTrabajadores(i, 0))

                If (iFechaItem >= iFechaInicial And iFechaItem <= iFechaFinal) Then
                    dgvTrabajadores.Rows.Add()

                    For j = 0 To iColumnas - 1
                        dgvTrabajadores.Rows(iIncremento).Cells(j).Value = aTrabajadores(i, j)
                    Next j

                    iIncremento += 1
                End If
            End If
        Next i

        With gbxListaTrabajadores
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With
    End Sub

    Private Sub NóminaDeTrabajadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NóminaDeTrabajadoresToolStripMenuItem.Click
        CerrarVentanas()

        iIncremento = 0
        cbxNombreApellidos.Items.Clear()

        For i = 0 To iPersonas - 1
            sValor = aTrabajadores(i, 1)

            If (IsNothing(sValor)) Then
                Exit For
            Else
                If sValor.Trim <> "" Then
                    cbxNombreApellidos.Items.Add(sValor)
                End If
            End If
        Next i

        With gbxNominaTrabajadores
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With
    End Sub

    Private Sub TipoDeCambioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDeCambioToolStripMenuItem.Click
        CerrarVentanas()

        numTipoCambio.Value = dTipoCambio

        With gbxTipoCambio
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With
    End Sub

    Private Sub TipoDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoDePagoToolStripMenuItem.Click
        CerrarVentanas()

        numPagoFijo.Value = dPagoFijo
        numPagoTemporal.Value = dPagoTemporal

        With gbxTipoPago
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With
    End Sub

    Private Sub AcercaDeRetoTécnicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcercaDeRetoTécnicoToolStripMenuItem.Click
        CerrarVentanas()

        With gbxAcercaDe
            .Location = New Point((Me.Width \ 2) - (.Width \ 2), (Me.Height \ 2) - (.Height \ 2))
            .Visible = True
        End With
    End Sub

    Private Sub CerrarProyectoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarProyectoToolStripMenuItem.Click
        Application.Exit()
    End Sub
    'BLOQUE MENU

    'BLOQUE AGREGAR TRABAJADOR
    Private Sub btnGuardarAgregarTrabajador_Click(sender As Object, e As EventArgs) Handles btnGuardarAgregarTrabajador.Click
        'Validar campos
        If txtAgregarNombreApellidos.Text.Trim() = "" Then
            MsgBox("Complete nombre y apellidos del trabajador!", vbYes, "Agregar Trabajador")
            Exit Sub
        End If

        If cbxAgregarModalidad.Text.Trim = "" Then
            MsgBox("Complete modalidad del trabajador!", vbYes, "Agregar Trabajador")
            Exit Sub
        End If

        If numAgregarHoras.Value = 0 Then
            MsgBox("Complete horas del trabajador!", vbYes, "Agregar Trabajador")
            Exit Sub
        End If

        For i = 0 To iPersonas - 1
            sValor = aTrabajadores(i, 0)

            If (IsNothing(sValor)) Then
                dtToday = Date.Today

                sDia = dtToday.Day.ToString().Trim()
                sMes = dtToday.Month.ToString().Trim()
                sAno = dtToday.Year.ToString().Trim()

                If sDia.ToString().Trim().Length = 1 Then
                    sDia = "0" + sDia
                End If

                If sMes.ToString().Trim().Length = 1 Then
                    sMes = "0" + sMes
                End If

                'MsgBox(sAno + sMes + sDia)
                aTrabajadores(i, 0) = sAno + sMes + sDia

                aTrabajadores(i, 1) = txtAgregarNombreApellidos.Text.Trim()

                aTrabajadores(i, 2) = cbxAgregarModalidad.Text.Trim()
                aTrabajadores(i, 3) = numAgregarHoras.Value.ToString().Trim()
                aTrabajadores(i, 4) = dTipoCambio.ToString("F2").Trim()

                Select Case cbxAgregarModalidad.Text.Trim()
                    Case "Fijo"
                        aTrabajadores(i, 5) = (numAgregarHoras.Value * dTipoCambio * dPagoFijo).ToString("F2").Trim()
                        aTrabajadores(i, 6) = (numAgregarHoras.Value * dPagoFijo).ToString("F2").Trim()
                    Case "Temporal"
                        aTrabajadores(i, 5) = (numAgregarHoras.Value * dTipoCambio * dPagoTemporal).ToString("F2").Trim()
                        aTrabajadores(i, 6) = (numAgregarHoras.Value * dPagoTemporal).ToString("F2").Trim()
                    Case Else
                        MsgBox("Modalidad de trabajo no seleccionada!", vbYes, "Agregar Trabajador")
                End Select


                'Agregar a Base de datos
                'Create a Connection object
                myConn = New SqlConnection("Data Source=LAP-5CG12317YM\SQLEXPRESS;Initial Catalog=RetoTecnico;Integrated Security=True")

                'Open the connection
                myConn.Open()

                'Create a Command object
                myCmd = myConn.CreateCommand
                myCmd.CommandText = "INSERT INTO Trabajadores(Id, Fecha, NombreApellido, Modalidad, Horas, TipoCambio, PagoSoles, PagoDolares) VALUES(" + i.ToString().Trim() + ", '" + aTrabajadores(i, 0) + "', '" + aTrabajadores(i, 1) + "', '" + aTrabajadores(i, 2) + "', " + aTrabajadores(i, 3) + ", " + aTrabajadores(i, 4) + ", " + aTrabajadores(i, 5) + ", " + aTrabajadores(i, 6) + ")"
                myCmd.ExecuteNonQuery()

                'Close the reader and the database connection
                myConn.Close()


                MsgBox("Trabajador agregado correctamente!", vbYes, "Agregar Trabajador")
                Exit For
            End If
        Next i

        txtAgregarNombreApellidos.Text = ""
        cbxAgregarModalidad.SelectedIndex = 0
        numAgregarHoras.Value = 0

        txtAgregarNombreApellidos.Focus()
    End Sub

    Private Sub btnCerrarAgregarTrabajador_Click(sender As Object, e As EventArgs) Handles btnCerrarAgregarTrabajador.Click
        gbxAgregarTrabajador.Visible = False
    End Sub
    'BLOQUE AGREGAR TRABAJADOR

    'BLOQUE LISTA DE TRABAJADORES
    Private Sub btnBuscarListaTrabajadores_Click(sender As Object, e As EventArgs) Handles btnBuscarListaTrabajadores.Click
        iFechaInicial = dtpFechaInicial.Value.ToString("yyyyMMdd")
        iFechaFinal = dtpFechaFinal.Value.ToString("yyyyMMdd")

        iIncremento = 0
        dgvTrabajadores.Rows.Clear()

        For i = 0 To iPersonas - 1
            sValor = aTrabajadores(i, 0)

            If (IsNothing(sValor)) Then
                Exit For
            Else
                iFechaItem = Integer.Parse(aTrabajadores(i, 0))

                If (iFechaItem >= iFechaInicial And iFechaItem <= iFechaFinal) Then
                    dgvTrabajadores.Rows.Add()

                    For j = 0 To iColumnas - 1
                        dgvTrabajadores.Rows(iIncremento).Cells(j).Value = aTrabajadores(i, j)
                    Next j

                    iIncremento += 1
                End If
            End If
        Next i
    End Sub

    Private Sub btnCerrarListaTrabajadores_Click(sender As Object, e As EventArgs) Handles btnCerrarListaTrabajadores.Click
        gbxListaTrabajadores.Visible = False
    End Sub
    'BLOQUE LISTA DE TRABAJADORES

    'BLOQUE NOMINA DE TRABAJADORES
    Private Sub cbxNombreApellidos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxNombreApellidos.SelectedIndexChanged
        bProcesoTrabajador = True
        sNombre = cbxNombreApellidos.Text

        If sNombre.Trim <> "" Then
            cbxModalidad.Enabled = True
            numHoras.Enabled = True

            For i = 0 To iPersonas - 1
                sValor = aTrabajadores(i, 1)

                If (IsNothing(sValor)) Then
                    bProcesoTrabajador = False
                    Exit For
                Else
                    If sValor = sNombre Then
                        cbxModalidad.Text = aTrabajadores(i, 2)
                        numHoras.Value = aTrabajadores(i, 3)

                        'txtTipoCambio.Text = aTrabajadores(i, 4)
                        'txtPagoSoles.Text = aTrabajadores(i, 5)
                        'txtPagoDolares.Text = aTrabajadores(i, 6)

                        txtTipoCambio.Text = dTipoCambio.ToString("F2").Trim()

                        Select Case cbxModalidad.Text.Trim()
                            Case "Fijo"
                                txtPagoDolares.Text = (numHoras.Value * dPagoFijo).ToString("F2").Trim()
                                txtPagoSoles.Text = (numHoras.Value * dTipoCambio * dPagoFijo).ToString("F2").Trim()
                            Case "Temporal"
                                txtPagoDolares.Text = (numHoras.Value * dPagoTemporal).ToString("F2").Trim()
                                txtPagoSoles.Text = (numHoras.Value * dTipoCambio * dPagoTemporal).ToString("F2").Trim()
                            Case Else
                                MsgBox("Modalidad de Pago no existe!", vbYes, "Nómina de Trabajadores")
                        End Select

                        bProcesoTrabajador = False
                        Exit For
                    End If
                End If
            Next i
        End If

        bProcesoTrabajador = False
    End Sub

    Private Sub cbxModalidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxModalidad.SelectedIndexChanged
        If Not bProcesoTrabajador Then
            bProcesoModalidad = True

            txtTipoCambio.Text = dTipoCambio.ToString("F2").Trim()

            Select Case cbxModalidad.Text.Trim()
                Case "Fijo"
                    txtPagoDolares.Text = (numHoras.Value * dPagoFijo).ToString("F2").Trim()
                    txtPagoSoles.Text = (numHoras.Value * dTipoCambio * dPagoFijo).ToString("F2").Trim()
                Case "Temporal"
                    txtPagoDolares.Text = (numHoras.Value * dPagoTemporal).ToString("F2").Trim()
                    txtPagoSoles.Text = (numHoras.Value * dTipoCambio * dPagoTemporal).ToString("F2").Trim()
                Case Else
                    MsgBox("Modalidad de Pago no existe!", vbYes, "Nómina de Trabajadores")
            End Select

            bProcesoModalidad = False
        End If
    End Sub

    Private Sub numHoras_ValueChanged(sender As Object, e As EventArgs) Handles numHoras.ValueChanged
        If Not bProcesoTrabajador Then
            bProcesoHoras = True

            txtTipoCambio.Text = dTipoCambio.ToString("F2").Trim()

            Select Case cbxModalidad.Text.Trim()
                Case "Fijo"
                    txtPagoDolares.Text = (numHoras.Value * dPagoFijo).ToString("F2").Trim()
                    txtPagoSoles.Text = (numHoras.Value * dTipoCambio * dPagoFijo).ToString("F2").Trim()
                Case "Temporal"
                    txtPagoDolares.Text = (numHoras.Value * dPagoTemporal).ToString("F2").Trim()
                    txtPagoSoles.Text = (numHoras.Value * dTipoCambio * dPagoTemporal).ToString("F2").Trim()
                Case Else
                    MsgBox("Modalidad de Pago no existe!", vbYes, "Nómina de Trabajadores")
            End Select

            bProcesoHoras = False
        End If
    End Sub

    Private Sub btnGuardarNominaTrabajador_Click(sender As Object, e As EventArgs) Handles btnGuardarNominaTrabajador.Click
        sNombre = cbxNombreApellidos.Text.Trim()

        If sNombre <> "" Then
            For i = 0 To iPersonas - 1
                sValor = aTrabajadores(i, 1).Trim()

                If (IsNothing(sValor)) Then
                    bProcesoTrabajador = False
                    Exit For
                Else
                    If sValor = sNombre Then
                        dtToday = Date.Today

                        sDia = dtToday.Day.ToString().Trim()
                        sMes = dtToday.Month.ToString().Trim()
                        sAno = dtToday.Year.ToString().Trim()

                        If sDia.ToString().Trim().Length = 1 Then
                            sDia = "0" + sDia
                        End If

                        If sMes.ToString().Trim().Length = 1 Then
                            sMes = "0" + sMes
                        End If

                        'MsgBox(sAno + sMes + sDia)
                        aTrabajadores(i, 0) = sAno + sMes + sDia

                        aTrabajadores(i, 2) = cbxModalidad.Text.Trim()
                        aTrabajadores(i, 3) = numHoras.Value.ToString().Trim()
                        aTrabajadores(i, 4) = txtTipoCambio.Text.Trim()
                        aTrabajadores(i, 5) = txtPagoSoles.Text.Trim()
                        aTrabajadores(i, 6) = txtPagoDolares.Text.Trim()


                        'Actualizar Base de datos
                        'Create a Connection object
                        myConn = New SqlConnection("Data Source=LAP-5CG12317YM\SQLEXPRESS;Initial Catalog=RetoTecnico;Integrated Security=True")

                        'Open the connection
                        myConn.Open()

                        'Create a Command object
                        myCmd = myConn.CreateCommand
                        myCmd.CommandText = "UPDATE Trabajadores SET Fecha = '" + aTrabajadores(i, 0) + "', Modalidad = '" + aTrabajadores(i, 2) + "', Horas = " + aTrabajadores(i, 3) + ", TipoCambio = " + aTrabajadores(i, 4) + ", PagoSoles = " + aTrabajadores(i, 5) + ", PagoDolares = " + aTrabajadores(i, 6) + " WHERE NombreApellido = '" + sValor + "'"
                        myCmd.ExecuteNonQuery()

                        'Close the reader and the database connection
                        myConn.Close()


                        MsgBox("Nómina de trabajador actualizada correctamente!", vbYes, "Nómina de Trabajadores")
                        Exit For
                    End If
                End If
            Next i
        Else
            MsgBox("Por favor seleccione un trabajador!", vbYes, "Nómina de Trabajadores")
        End If
    End Sub

    Private Sub btnCerrarNominaTrabajadores_Click(sender As Object, e As EventArgs) Handles btnCerrarNominaTrabajadores.Click
        gbxNominaTrabajadores.Visible = False
    End Sub
    'BLOQUE NOMINA DE TRABAJADORES

    'BLOQUE TIPO DE CAMBIO
    Private Sub btnEliminarTipoCambio_Click(sender As Object, e As EventArgs) Handles btnEliminarTipoCambio.Click
        numTipoCambio.Value = 0
        dTipoCambio = numTipoCambio.Value

        MsgBox("Tipo de Cambio eliminado correctamente!", vbYes, "Tipo de Cambio")
    End Sub

    Private Sub btnGuardarTipoCambio_Click(sender As Object, e As EventArgs) Handles btnGuardarTipoCambio.Click
        dTipoCambio = numTipoCambio.Value

        MsgBox("Tipo de Cambio actualizado correctamente!", vbYes, "Tipo de Cambio")
    End Sub

    Private Sub btnCerrarTipoCambio_Click(sender As Object, e As EventArgs) Handles btnCerrarTipoCambio.Click
        gbxTipoCambio.Visible = False
    End Sub
    'BLOQUE TIPO DE CAMBIO

    'BLOQUE TIPO DE PAGO
    Private Sub btnGuardarTipoPago_Click(sender As Object, e As EventArgs) Handles btnGuardarTipoPago.Click
        dPagoFijo = numPagoFijo.Value
        dPagoTemporal = numPagoTemporal.Value

        MsgBox("Tipos de Pago actualizados correctamente!", vbYes, "Tipo de Pago")
    End Sub

    Private Sub btnCerrarTipoPago_Click(sender As Object, e As EventArgs) Handles btnCerrarTipoPago.Click
        gbxTipoPago.Visible = False
    End Sub
    'BLOQUE TIPO DE PAGO

    'BLOQUE ACERCA DE
    Private Sub btnCerrarAcercaDe_Click(sender As Object, e As EventArgs) Handles btnCerrarAcercaDe.Click
        gbxAcercaDe.Visible = False
    End Sub
    'BLOQUE ACERCA DE
End Class
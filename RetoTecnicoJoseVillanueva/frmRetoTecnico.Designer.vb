<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRetoTecnico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRetoTecnico))
        Me.mnuRetoTecnico = New System.Windows.Forms.MenuStrip()
        Me.TrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarTrabajadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDeTrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NóminaDeTrabajadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDeCambioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarProyectoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcercaDeRetoTécnicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gbxAcercaDe = New System.Windows.Forms.GroupBox()
        Me.btnCerrarAcercaDe = New System.Windows.Forms.Button()
        Me.lblFechaDesarrollo = New System.Windows.Forms.Label()
        Me.lblParaEmpresa = New System.Windows.Forms.Label()
        Me.lblDesarrollador = New System.Windows.Forms.Label()
        Me.gbxTipoCambio = New System.Windows.Forms.GroupBox()
        Me.btnCerrarTipoCambio = New System.Windows.Forms.Button()
        Me.btnGuardarTipoCambio = New System.Windows.Forms.Button()
        Me.btnEliminarTipoCambio = New System.Windows.Forms.Button()
        Me.numTipoCambio = New System.Windows.Forms.NumericUpDown()
        Me.lblValorDolar = New System.Windows.Forms.Label()
        Me.gbxTipoPago = New System.Windows.Forms.GroupBox()
        Me.numPagoTemporal = New System.Windows.Forms.NumericUpDown()
        Me.lblPagoTemporal = New System.Windows.Forms.Label()
        Me.btnCerrarTipoPago = New System.Windows.Forms.Button()
        Me.btnGuardarTipoPago = New System.Windows.Forms.Button()
        Me.numPagoFijo = New System.Windows.Forms.NumericUpDown()
        Me.lblPagoFijo = New System.Windows.Forms.Label()
        Me.gbxListaTrabajadores = New System.Windows.Forms.GroupBox()
        Me.btnCerrarListaTrabajadores = New System.Windows.Forms.Button()
        Me.lblFechaInicial = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.dtpFechaInicial = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dgvTrabajadores = New System.Windows.Forms.DataGridView()
        Me.dgFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgNombreApellidos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgModalidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgHoras = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgTipoCambio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgPagoSoles = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgPagoDolares = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnBuscarListaTrabajadores = New System.Windows.Forms.Button()
        Me.gbxNominaTrabajadores = New System.Windows.Forms.GroupBox()
        Me.btnCerrarNominaTrabajadores = New System.Windows.Forms.Button()
        Me.lblNombreApellidos = New System.Windows.Forms.Label()
        Me.lblModalidad = New System.Windows.Forms.Label()
        Me.lblHoras = New System.Windows.Forms.Label()
        Me.lblTipoCambio = New System.Windows.Forms.Label()
        Me.lblPagoSoles = New System.Windows.Forms.Label()
        Me.lblPagoDolares = New System.Windows.Forms.Label()
        Me.cbxNombreApellidos = New System.Windows.Forms.ComboBox()
        Me.cbxModalidad = New System.Windows.Forms.ComboBox()
        Me.txtTipoCambio = New System.Windows.Forms.TextBox()
        Me.txtPagoSoles = New System.Windows.Forms.TextBox()
        Me.txtPagoDolares = New System.Windows.Forms.TextBox()
        Me.btnGuardarNominaTrabajador = New System.Windows.Forms.Button()
        Me.lblSeleccioneTrabajador = New System.Windows.Forms.Label()
        Me.numHoras = New System.Windows.Forms.NumericUpDown()
        Me.gbxAgregarTrabajador = New System.Windows.Forms.GroupBox()
        Me.numAgregarHoras = New System.Windows.Forms.NumericUpDown()
        Me.lblCompletarCampos = New System.Windows.Forms.Label()
        Me.btnGuardarAgregarTrabajador = New System.Windows.Forms.Button()
        Me.cbxAgregarModalidad = New System.Windows.Forms.ComboBox()
        Me.lblAgregarHoras = New System.Windows.Forms.Label()
        Me.lblAgregarModalidad = New System.Windows.Forms.Label()
        Me.lblAgregarNombre = New System.Windows.Forms.Label()
        Me.btnCerrarAgregarTrabajador = New System.Windows.Forms.Button()
        Me.txtAgregarNombreApellidos = New System.Windows.Forms.TextBox()
        Me.lblIndicaciones = New System.Windows.Forms.Label()
        Me.mnuRetoTecnico.SuspendLayout()
        Me.gbxAcercaDe.SuspendLayout()
        Me.gbxTipoCambio.SuspendLayout()
        CType(Me.numTipoCambio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTipoPago.SuspendLayout()
        CType(Me.numPagoTemporal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPagoFijo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxListaTrabajadores.SuspendLayout()
        CType(Me.dgvTrabajadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxNominaTrabajadores.SuspendLayout()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxAgregarTrabajador.SuspendLayout()
        CType(Me.numAgregarHoras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuRetoTecnico
        '
        Me.mnuRetoTecnico.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TrabajadoresToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.mnuRetoTecnico.Location = New System.Drawing.Point(0, 0)
        Me.mnuRetoTecnico.Name = "mnuRetoTecnico"
        Me.mnuRetoTecnico.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.mnuRetoTecnico.Size = New System.Drawing.Size(984, 24)
        Me.mnuRetoTecnico.TabIndex = 0
        Me.mnuRetoTecnico.Text = "MenuStrip1"
        '
        'TrabajadoresToolStripMenuItem
        '
        Me.TrabajadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarTrabajadorToolStripMenuItem, Me.ListaDeTrabajadoresToolStripMenuItem, Me.NóminaDeTrabajadoresToolStripMenuItem})
        Me.TrabajadoresToolStripMenuItem.Name = "TrabajadoresToolStripMenuItem"
        Me.TrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.TrabajadoresToolStripMenuItem.Text = "Trabajadores"
        '
        'AgregarTrabajadorToolStripMenuItem
        '
        Me.AgregarTrabajadorToolStripMenuItem.Name = "AgregarTrabajadorToolStripMenuItem"
        Me.AgregarTrabajadorToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.AgregarTrabajadorToolStripMenuItem.Text = "Agregar Trabajador"
        '
        'ListaDeTrabajadoresToolStripMenuItem
        '
        Me.ListaDeTrabajadoresToolStripMenuItem.Name = "ListaDeTrabajadoresToolStripMenuItem"
        Me.ListaDeTrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.ListaDeTrabajadoresToolStripMenuItem.Text = "Lista de Trabajadores"
        '
        'NóminaDeTrabajadoresToolStripMenuItem
        '
        Me.NóminaDeTrabajadoresToolStripMenuItem.Name = "NóminaDeTrabajadoresToolStripMenuItem"
        Me.NóminaDeTrabajadoresToolStripMenuItem.Size = New System.Drawing.Size(202, 22)
        Me.NóminaDeTrabajadoresToolStripMenuItem.Text = "Nómina de Trabajadores"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoDeCambioToolStripMenuItem, Me.TipoDePagoToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'TipoDeCambioToolStripMenuItem
        '
        Me.TipoDeCambioToolStripMenuItem.Name = "TipoDeCambioToolStripMenuItem"
        Me.TipoDeCambioToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TipoDeCambioToolStripMenuItem.Text = "Tipo de Cambio"
        '
        'TipoDePagoToolStripMenuItem
        '
        Me.TipoDePagoToolStripMenuItem.Name = "TipoDePagoToolStripMenuItem"
        Me.TipoDePagoToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.TipoDePagoToolStripMenuItem.Text = "Tipo de Pago"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CerrarProyectoToolStripMenuItem, Me.AcercaDeRetoTécnicoToolStripMenuItem})
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'CerrarProyectoToolStripMenuItem
        '
        Me.CerrarProyectoToolStripMenuItem.Name = "CerrarProyectoToolStripMenuItem"
        Me.CerrarProyectoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.CerrarProyectoToolStripMenuItem.Text = "Cerrar Proyecto"
        '
        'AcercaDeRetoTécnicoToolStripMenuItem
        '
        Me.AcercaDeRetoTécnicoToolStripMenuItem.Name = "AcercaDeRetoTécnicoToolStripMenuItem"
        Me.AcercaDeRetoTécnicoToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AcercaDeRetoTécnicoToolStripMenuItem.Text = "Acerca de Reto Técnico"
        '
        'gbxAcercaDe
        '
        Me.gbxAcercaDe.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxAcercaDe.Controls.Add(Me.lblIndicaciones)
        Me.gbxAcercaDe.Controls.Add(Me.btnCerrarAcercaDe)
        Me.gbxAcercaDe.Controls.Add(Me.lblFechaDesarrollo)
        Me.gbxAcercaDe.Controls.Add(Me.lblParaEmpresa)
        Me.gbxAcercaDe.Controls.Add(Me.lblDesarrollador)
        Me.gbxAcercaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAcercaDe.Location = New System.Drawing.Point(17, 45)
        Me.gbxAcercaDe.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxAcercaDe.Name = "gbxAcercaDe"
        Me.gbxAcercaDe.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxAcercaDe.Size = New System.Drawing.Size(571, 503)
        Me.gbxAcercaDe.TabIndex = 1
        Me.gbxAcercaDe.TabStop = False
        Me.gbxAcercaDe.Text = "Acerca de Reto Técnico"
        Me.gbxAcercaDe.Visible = False
        '
        'btnCerrarAcercaDe
        '
        Me.btnCerrarAcercaDe.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrarAcercaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarAcercaDe.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarAcercaDe.Location = New System.Drawing.Point(442, 40)
        Me.btnCerrarAcercaDe.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarAcercaDe.Name = "btnCerrarAcercaDe"
        Me.btnCerrarAcercaDe.Size = New System.Drawing.Size(100, 32)
        Me.btnCerrarAcercaDe.TabIndex = 3
        Me.btnCerrarAcercaDe.Text = "Cerrar"
        Me.btnCerrarAcercaDe.UseVisualStyleBackColor = False
        '
        'lblFechaDesarrollo
        '
        Me.lblFechaDesarrollo.AutoSize = True
        Me.lblFechaDesarrollo.Location = New System.Drawing.Point(27, 81)
        Me.lblFechaDesarrollo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaDesarrollo.Name = "lblFechaDesarrollo"
        Me.lblFechaDesarrollo.Size = New System.Drawing.Size(159, 17)
        Me.lblFechaDesarrollo.TabIndex = 2
        Me.lblFechaDesarrollo.Text = "Fecha: Noviembre 2022"
        '
        'lblParaEmpresa
        '
        Me.lblParaEmpresa.AutoSize = True
        Me.lblParaEmpresa.Location = New System.Drawing.Point(27, 60)
        Me.lblParaEmpresa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblParaEmpresa.Name = "lblParaEmpresa"
        Me.lblParaEmpresa.Size = New System.Drawing.Size(124, 17)
        Me.lblParaEmpresa.TabIndex = 1
        Me.lblParaEmpresa.Text = "Para: Softtek Perú"
        '
        'lblDesarrollador
        '
        Me.lblDesarrollador.AutoSize = True
        Me.lblDesarrollador.Location = New System.Drawing.Point(27, 40)
        Me.lblDesarrollador.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDesarrollador.Name = "lblDesarrollador"
        Me.lblDesarrollador.Size = New System.Drawing.Size(276, 17)
        Me.lblDesarrollador.TabIndex = 0
        Me.lblDesarrollador.Text = "Desarrollado por: José Villanueva Miranda"
        '
        'gbxTipoCambio
        '
        Me.gbxTipoCambio.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxTipoCambio.Controls.Add(Me.btnCerrarTipoCambio)
        Me.gbxTipoCambio.Controls.Add(Me.btnGuardarTipoCambio)
        Me.gbxTipoCambio.Controls.Add(Me.btnEliminarTipoCambio)
        Me.gbxTipoCambio.Controls.Add(Me.numTipoCambio)
        Me.gbxTipoCambio.Controls.Add(Me.lblValorDolar)
        Me.gbxTipoCambio.Location = New System.Drawing.Point(621, 45)
        Me.gbxTipoCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxTipoCambio.Name = "gbxTipoCambio"
        Me.gbxTipoCambio.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxTipoCambio.Size = New System.Drawing.Size(350, 145)
        Me.gbxTipoCambio.TabIndex = 2
        Me.gbxTipoCambio.TabStop = False
        Me.gbxTipoCambio.Text = "Tipo de Cambio"
        Me.gbxTipoCambio.Visible = False
        '
        'btnCerrarTipoCambio
        '
        Me.btnCerrarTipoCambio.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrarTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarTipoCambio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarTipoCambio.Location = New System.Drawing.Point(234, 95)
        Me.btnCerrarTipoCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarTipoCambio.Name = "btnCerrarTipoCambio"
        Me.btnCerrarTipoCambio.Size = New System.Drawing.Size(100, 32)
        Me.btnCerrarTipoCambio.TabIndex = 6
        Me.btnCerrarTipoCambio.Text = "Cerrar"
        Me.btnCerrarTipoCambio.UseVisualStyleBackColor = False
        '
        'btnGuardarTipoCambio
        '
        Me.btnGuardarTipoCambio.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarTipoCambio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarTipoCambio.Location = New System.Drawing.Point(126, 95)
        Me.btnGuardarTipoCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarTipoCambio.Name = "btnGuardarTipoCambio"
        Me.btnGuardarTipoCambio.Size = New System.Drawing.Size(100, 32)
        Me.btnGuardarTipoCambio.TabIndex = 5
        Me.btnGuardarTipoCambio.Text = "Guardar"
        Me.btnGuardarTipoCambio.UseVisualStyleBackColor = False
        '
        'btnEliminarTipoCambio
        '
        Me.btnEliminarTipoCambio.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnEliminarTipoCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarTipoCambio.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnEliminarTipoCambio.Location = New System.Drawing.Point(18, 95)
        Me.btnEliminarTipoCambio.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEliminarTipoCambio.Name = "btnEliminarTipoCambio"
        Me.btnEliminarTipoCambio.Size = New System.Drawing.Size(100, 32)
        Me.btnEliminarTipoCambio.TabIndex = 4
        Me.btnEliminarTipoCambio.Text = "Eliminar"
        Me.btnEliminarTipoCambio.UseVisualStyleBackColor = False
        '
        'numTipoCambio
        '
        Me.numTipoCambio.DecimalPlaces = 2
        Me.numTipoCambio.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numTipoCambio.Location = New System.Drawing.Point(187, 43)
        Me.numTipoCambio.Name = "numTipoCambio"
        Me.numTipoCambio.Size = New System.Drawing.Size(80, 23)
        Me.numTipoCambio.TabIndex = 2
        Me.numTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numTipoCambio.ThousandsSeparator = True
        '
        'lblValorDolar
        '
        Me.lblValorDolar.AutoSize = True
        Me.lblValorDolar.Location = New System.Drawing.Point(74, 45)
        Me.lblValorDolar.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblValorDolar.Name = "lblValorDolar"
        Me.lblValorDolar.Size = New System.Drawing.Size(106, 17)
        Me.lblValorDolar.TabIndex = 0
        Me.lblValorDolar.Text = "Valor del Dolar:"
        '
        'gbxTipoPago
        '
        Me.gbxTipoPago.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxTipoPago.Controls.Add(Me.numPagoTemporal)
        Me.gbxTipoPago.Controls.Add(Me.lblPagoTemporal)
        Me.gbxTipoPago.Controls.Add(Me.btnCerrarTipoPago)
        Me.gbxTipoPago.Controls.Add(Me.btnGuardarTipoPago)
        Me.gbxTipoPago.Controls.Add(Me.numPagoFijo)
        Me.gbxTipoPago.Controls.Add(Me.lblPagoFijo)
        Me.gbxTipoPago.Location = New System.Drawing.Point(639, 198)
        Me.gbxTipoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxTipoPago.Name = "gbxTipoPago"
        Me.gbxTipoPago.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxTipoPago.Size = New System.Drawing.Size(350, 182)
        Me.gbxTipoPago.TabIndex = 7
        Me.gbxTipoPago.TabStop = False
        Me.gbxTipoPago.Text = "Tipo de Pago"
        Me.gbxTipoPago.Visible = False
        '
        'numPagoTemporal
        '
        Me.numPagoTemporal.DecimalPlaces = 2
        Me.numPagoTemporal.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numPagoTemporal.Location = New System.Drawing.Point(218, 78)
        Me.numPagoTemporal.Name = "numPagoTemporal"
        Me.numPagoTemporal.Size = New System.Drawing.Size(80, 23)
        Me.numPagoTemporal.TabIndex = 8
        Me.numPagoTemporal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPagoTemporal.ThousandsSeparator = True
        '
        'lblPagoTemporal
        '
        Me.lblPagoTemporal.AutoSize = True
        Me.lblPagoTemporal.Location = New System.Drawing.Point(48, 80)
        Me.lblPagoTemporal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPagoTemporal.Name = "lblPagoTemporal"
        Me.lblPagoTemporal.Size = New System.Drawing.Size(163, 17)
        Me.lblPagoTemporal.TabIndex = 7
        Me.lblPagoTemporal.Text = "Modalidad Temporal ($):"
        '
        'btnCerrarTipoPago
        '
        Me.btnCerrarTipoPago.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrarTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarTipoPago.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarTipoPago.Location = New System.Drawing.Point(180, 127)
        Me.btnCerrarTipoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarTipoPago.Name = "btnCerrarTipoPago"
        Me.btnCerrarTipoPago.Size = New System.Drawing.Size(100, 32)
        Me.btnCerrarTipoPago.TabIndex = 6
        Me.btnCerrarTipoPago.Text = "Cerrar"
        Me.btnCerrarTipoPago.UseVisualStyleBackColor = False
        '
        'btnGuardarTipoPago
        '
        Me.btnGuardarTipoPago.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarTipoPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarTipoPago.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarTipoPago.Location = New System.Drawing.Point(72, 127)
        Me.btnGuardarTipoPago.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarTipoPago.Name = "btnGuardarTipoPago"
        Me.btnGuardarTipoPago.Size = New System.Drawing.Size(100, 32)
        Me.btnGuardarTipoPago.TabIndex = 5
        Me.btnGuardarTipoPago.Text = "Guardar"
        Me.btnGuardarTipoPago.UseVisualStyleBackColor = False
        '
        'numPagoFijo
        '
        Me.numPagoFijo.DecimalPlaces = 2
        Me.numPagoFijo.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.numPagoFijo.Location = New System.Drawing.Point(218, 43)
        Me.numPagoFijo.Name = "numPagoFijo"
        Me.numPagoFijo.Size = New System.Drawing.Size(80, 23)
        Me.numPagoFijo.TabIndex = 2
        Me.numPagoFijo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numPagoFijo.ThousandsSeparator = True
        '
        'lblPagoFijo
        '
        Me.lblPagoFijo.AutoSize = True
        Me.lblPagoFijo.Location = New System.Drawing.Point(86, 45)
        Me.lblPagoFijo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPagoFijo.Name = "lblPagoFijo"
        Me.lblPagoFijo.Size = New System.Drawing.Size(125, 17)
        Me.lblPagoFijo.TabIndex = 0
        Me.lblPagoFijo.Text = "Modalidad Fijo ($):"
        '
        'gbxListaTrabajadores
        '
        Me.gbxListaTrabajadores.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxListaTrabajadores.Controls.Add(Me.btnBuscarListaTrabajadores)
        Me.gbxListaTrabajadores.Controls.Add(Me.dgvTrabajadores)
        Me.gbxListaTrabajadores.Controls.Add(Me.dtpFechaFinal)
        Me.gbxListaTrabajadores.Controls.Add(Me.dtpFechaInicial)
        Me.gbxListaTrabajadores.Controls.Add(Me.lblFechaFinal)
        Me.gbxListaTrabajadores.Controls.Add(Me.lblFechaInicial)
        Me.gbxListaTrabajadores.Controls.Add(Me.btnCerrarListaTrabajadores)
        Me.gbxListaTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxListaTrabajadores.Location = New System.Drawing.Point(17, 487)
        Me.gbxListaTrabajadores.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxListaTrabajadores.Name = "gbxListaTrabajadores"
        Me.gbxListaTrabajadores.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxListaTrabajadores.Size = New System.Drawing.Size(935, 424)
        Me.gbxListaTrabajadores.TabIndex = 4
        Me.gbxListaTrabajadores.TabStop = False
        Me.gbxListaTrabajadores.Text = "Lista de Trabajadores"
        Me.gbxListaTrabajadores.Visible = False
        '
        'btnCerrarListaTrabajadores
        '
        Me.btnCerrarListaTrabajadores.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrarListaTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarListaTrabajadores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarListaTrabajadores.Location = New System.Drawing.Point(420, 376)
        Me.btnCerrarListaTrabajadores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarListaTrabajadores.Name = "btnCerrarListaTrabajadores"
        Me.btnCerrarListaTrabajadores.Size = New System.Drawing.Size(100, 32)
        Me.btnCerrarListaTrabajadores.TabIndex = 3
        Me.btnCerrarListaTrabajadores.Text = "Cerrar"
        Me.btnCerrarListaTrabajadores.UseVisualStyleBackColor = False
        '
        'lblFechaInicial
        '
        Me.lblFechaInicial.AutoSize = True
        Me.lblFechaInicial.Location = New System.Drawing.Point(174, 50)
        Me.lblFechaInicial.Name = "lblFechaInicial"
        Me.lblFechaInicial.Size = New System.Drawing.Size(90, 17)
        Me.lblFechaInicial.TabIndex = 4
        Me.lblFechaInicial.Text = "Fecha Inicial:"
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.AutoSize = True
        Me.lblFechaFinal.Location = New System.Drawing.Point(422, 50)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(85, 17)
        Me.lblFechaFinal.TabIndex = 5
        Me.lblFechaFinal.Text = "Fecha Final:"
        '
        'dtpFechaInicial
        '
        Me.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicial.Location = New System.Drawing.Point(270, 48)
        Me.dtpFechaInicial.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaInicial.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaInicial.Name = "dtpFechaInicial"
        Me.dtpFechaInicial.Size = New System.Drawing.Size(110, 23)
        Me.dtpFechaInicial.TabIndex = 6
        Me.dtpFechaInicial.Value = New Date(2022, 1, 1, 0, 0, 0, 0)
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(513, 48)
        Me.dtpFechaFinal.MaxDate = New Date(3000, 12, 31, 0, 0, 0, 0)
        Me.dtpFechaFinal.MinDate = New Date(1800, 1, 1, 0, 0, 0, 0)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(110, 23)
        Me.dtpFechaFinal.TabIndex = 7
        Me.dtpFechaFinal.Value = New Date(2022, 12, 31, 0, 0, 0, 0)
        '
        'dgvTrabajadores
        '
        Me.dgvTrabajadores.AllowUserToAddRows = False
        Me.dgvTrabajadores.AllowUserToDeleteRows = False
        Me.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTrabajadores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgFecha, Me.dgNombreApellidos, Me.dgModalidad, Me.dgHoras, Me.dgTipoCambio, Me.dgPagoSoles, Me.dgPagoDolares})
        Me.dgvTrabajadores.Location = New System.Drawing.Point(19, 105)
        Me.dgvTrabajadores.Name = "dgvTrabajadores"
        Me.dgvTrabajadores.ReadOnly = True
        Me.dgvTrabajadores.Size = New System.Drawing.Size(898, 254)
        Me.dgvTrabajadores.TabIndex = 8
        '
        'dgFecha
        '
        Me.dgFecha.HeaderText = "Fecha"
        Me.dgFecha.Name = "dgFecha"
        Me.dgFecha.ReadOnly = True
        '
        'dgNombreApellidos
        '
        Me.dgNombreApellidos.FillWeight = 200.0!
        Me.dgNombreApellidos.HeaderText = "Nombre y Apellidos"
        Me.dgNombreApellidos.Name = "dgNombreApellidos"
        Me.dgNombreApellidos.ReadOnly = True
        Me.dgNombreApellidos.Width = 200
        '
        'dgModalidad
        '
        Me.dgModalidad.HeaderText = "Modalidad"
        Me.dgModalidad.Name = "dgModalidad"
        Me.dgModalidad.ReadOnly = True
        '
        'dgHoras
        '
        Me.dgHoras.FillWeight = 80.0!
        Me.dgHoras.HeaderText = "Horas"
        Me.dgHoras.Name = "dgHoras"
        Me.dgHoras.ReadOnly = True
        Me.dgHoras.Width = 80
        '
        'dgTipoCambio
        '
        Me.dgTipoCambio.FillWeight = 120.0!
        Me.dgTipoCambio.HeaderText = "Tipo Cambio"
        Me.dgTipoCambio.Name = "dgTipoCambio"
        Me.dgTipoCambio.ReadOnly = True
        Me.dgTipoCambio.Width = 120
        '
        'dgPagoSoles
        '
        Me.dgPagoSoles.FillWeight = 120.0!
        Me.dgPagoSoles.HeaderText = "Pago Soles"
        Me.dgPagoSoles.Name = "dgPagoSoles"
        Me.dgPagoSoles.ReadOnly = True
        Me.dgPagoSoles.Width = 120
        '
        'dgPagoDolares
        '
        Me.dgPagoDolares.FillWeight = 120.0!
        Me.dgPagoDolares.HeaderText = "Pago Dólares"
        Me.dgPagoDolares.Name = "dgPagoDolares"
        Me.dgPagoDolares.ReadOnly = True
        Me.dgPagoDolares.Width = 120
        '
        'btnBuscarListaTrabajadores
        '
        Me.btnBuscarListaTrabajadores.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBuscarListaTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarListaTrabajadores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnBuscarListaTrabajadores.Location = New System.Drawing.Point(667, 43)
        Me.btnBuscarListaTrabajadores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnBuscarListaTrabajadores.Name = "btnBuscarListaTrabajadores"
        Me.btnBuscarListaTrabajadores.Size = New System.Drawing.Size(100, 32)
        Me.btnBuscarListaTrabajadores.TabIndex = 9
        Me.btnBuscarListaTrabajadores.Text = "Buscar"
        Me.btnBuscarListaTrabajadores.UseVisualStyleBackColor = False
        '
        'gbxNominaTrabajadores
        '
        Me.gbxNominaTrabajadores.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxNominaTrabajadores.Controls.Add(Me.numHoras)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblSeleccioneTrabajador)
        Me.gbxNominaTrabajadores.Controls.Add(Me.btnGuardarNominaTrabajador)
        Me.gbxNominaTrabajadores.Controls.Add(Me.txtPagoDolares)
        Me.gbxNominaTrabajadores.Controls.Add(Me.txtPagoSoles)
        Me.gbxNominaTrabajadores.Controls.Add(Me.txtTipoCambio)
        Me.gbxNominaTrabajadores.Controls.Add(Me.cbxModalidad)
        Me.gbxNominaTrabajadores.Controls.Add(Me.cbxNombreApellidos)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblPagoDolares)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblPagoSoles)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblTipoCambio)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblHoras)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblModalidad)
        Me.gbxNominaTrabajadores.Controls.Add(Me.lblNombreApellidos)
        Me.gbxNominaTrabajadores.Controls.Add(Me.btnCerrarNominaTrabajadores)
        Me.gbxNominaTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxNominaTrabajadores.Location = New System.Drawing.Point(684, 388)
        Me.gbxNominaTrabajadores.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxNominaTrabajadores.Name = "gbxNominaTrabajadores"
        Me.gbxNominaTrabajadores.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxNominaTrabajadores.Size = New System.Drawing.Size(703, 276)
        Me.gbxNominaTrabajadores.TabIndex = 4
        Me.gbxNominaTrabajadores.TabStop = False
        Me.gbxNominaTrabajadores.Text = "Nómina de Trabajadores"
        Me.gbxNominaTrabajadores.Visible = False
        '
        'btnCerrarNominaTrabajadores
        '
        Me.btnCerrarNominaTrabajadores.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrarNominaTrabajadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarNominaTrabajadores.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarNominaTrabajadores.Location = New System.Drawing.Point(366, 218)
        Me.btnCerrarNominaTrabajadores.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarNominaTrabajadores.Name = "btnCerrarNominaTrabajadores"
        Me.btnCerrarNominaTrabajadores.Size = New System.Drawing.Size(100, 32)
        Me.btnCerrarNominaTrabajadores.TabIndex = 3
        Me.btnCerrarNominaTrabajadores.Text = "Cerrar"
        Me.btnCerrarNominaTrabajadores.UseVisualStyleBackColor = False
        '
        'lblNombreApellidos
        '
        Me.lblNombreApellidos.AutoSize = True
        Me.lblNombreApellidos.Location = New System.Drawing.Point(27, 70)
        Me.lblNombreApellidos.Name = "lblNombreApellidos"
        Me.lblNombreApellidos.Size = New System.Drawing.Size(134, 17)
        Me.lblNombreApellidos.TabIndex = 4
        Me.lblNombreApellidos.Text = "Nombre y Apellidos:"
        '
        'lblModalidad
        '
        Me.lblModalidad.AutoSize = True
        Me.lblModalidad.Location = New System.Drawing.Point(84, 114)
        Me.lblModalidad.Name = "lblModalidad"
        Me.lblModalidad.Size = New System.Drawing.Size(77, 17)
        Me.lblModalidad.TabIndex = 5
        Me.lblModalidad.Text = "Modalidad:"
        '
        'lblHoras
        '
        Me.lblHoras.AutoSize = True
        Me.lblHoras.Location = New System.Drawing.Point(111, 159)
        Me.lblHoras.Name = "lblHoras"
        Me.lblHoras.Size = New System.Drawing.Size(50, 17)
        Me.lblHoras.TabIndex = 6
        Me.lblHoras.Text = "Horas:"
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.AutoSize = True
        Me.lblTipoCambio.Location = New System.Drawing.Point(409, 70)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.Size = New System.Drawing.Size(111, 17)
        Me.lblTipoCambio.TabIndex = 7
        Me.lblTipoCambio.Text = "Tipo de Cambio:"
        '
        'lblPagoSoles
        '
        Me.lblPagoSoles.AutoSize = True
        Me.lblPagoSoles.Location = New System.Drawing.Point(436, 114)
        Me.lblPagoSoles.Name = "lblPagoSoles"
        Me.lblPagoSoles.Size = New System.Drawing.Size(84, 17)
        Me.lblPagoSoles.TabIndex = 8
        Me.lblPagoSoles.Text = "Pago Soles:"
        '
        'lblPagoDolares
        '
        Me.lblPagoDolares.AutoSize = True
        Me.lblPagoDolares.Location = New System.Drawing.Point(422, 159)
        Me.lblPagoDolares.Name = "lblPagoDolares"
        Me.lblPagoDolares.Size = New System.Drawing.Size(98, 17)
        Me.lblPagoDolares.TabIndex = 9
        Me.lblPagoDolares.Text = "Pago Dólares:"
        '
        'cbxNombreApellidos
        '
        Me.cbxNombreApellidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxNombreApellidos.FormattingEnabled = True
        Me.cbxNombreApellidos.Location = New System.Drawing.Point(167, 67)
        Me.cbxNombreApellidos.Name = "cbxNombreApellidos"
        Me.cbxNombreApellidos.Size = New System.Drawing.Size(200, 24)
        Me.cbxNombreApellidos.TabIndex = 10
        '
        'cbxModalidad
        '
        Me.cbxModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxModalidad.Enabled = False
        Me.cbxModalidad.FormattingEnabled = True
        Me.cbxModalidad.Items.AddRange(New Object() {"Fijo", "Temporal"})
        Me.cbxModalidad.Location = New System.Drawing.Point(167, 111)
        Me.cbxModalidad.Name = "cbxModalidad"
        Me.cbxModalidad.Size = New System.Drawing.Size(200, 24)
        Me.cbxModalidad.TabIndex = 11
        '
        'txtTipoCambio
        '
        Me.txtTipoCambio.Location = New System.Drawing.Point(526, 67)
        Me.txtTipoCambio.Name = "txtTipoCambio"
        Me.txtTipoCambio.ReadOnly = True
        Me.txtTipoCambio.Size = New System.Drawing.Size(120, 23)
        Me.txtTipoCambio.TabIndex = 13
        Me.txtTipoCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPagoSoles
        '
        Me.txtPagoSoles.Location = New System.Drawing.Point(526, 111)
        Me.txtPagoSoles.Name = "txtPagoSoles"
        Me.txtPagoSoles.ReadOnly = True
        Me.txtPagoSoles.Size = New System.Drawing.Size(120, 23)
        Me.txtPagoSoles.TabIndex = 14
        Me.txtPagoSoles.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPagoDolares
        '
        Me.txtPagoDolares.Location = New System.Drawing.Point(526, 156)
        Me.txtPagoDolares.Name = "txtPagoDolares"
        Me.txtPagoDolares.ReadOnly = True
        Me.txtPagoDolares.Size = New System.Drawing.Size(120, 23)
        Me.txtPagoDolares.TabIndex = 15
        Me.txtPagoDolares.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnGuardarNominaTrabajador
        '
        Me.btnGuardarNominaTrabajador.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarNominaTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarNominaTrabajador.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarNominaTrabajador.Location = New System.Drawing.Point(240, 218)
        Me.btnGuardarNominaTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarNominaTrabajador.Name = "btnGuardarNominaTrabajador"
        Me.btnGuardarNominaTrabajador.Size = New System.Drawing.Size(100, 32)
        Me.btnGuardarNominaTrabajador.TabIndex = 16
        Me.btnGuardarNominaTrabajador.Text = "Guardar"
        Me.btnGuardarNominaTrabajador.UseVisualStyleBackColor = False
        '
        'lblSeleccioneTrabajador
        '
        Me.lblSeleccioneTrabajador.AutoSize = True
        Me.lblSeleccioneTrabajador.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblSeleccioneTrabajador.Location = New System.Drawing.Point(27, 35)
        Me.lblSeleccioneTrabajador.Name = "lblSeleccioneTrabajador"
        Me.lblSeleccioneTrabajador.Size = New System.Drawing.Size(235, 17)
        Me.lblSeleccioneTrabajador.TabIndex = 17
        Me.lblSeleccioneTrabajador.Text = "Por favor seleccione un trabajador *"
        '
        'numHoras
        '
        Me.numHoras.Enabled = False
        Me.numHoras.Location = New System.Drawing.Point(167, 157)
        Me.numHoras.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.numHoras.Name = "numHoras"
        Me.numHoras.Size = New System.Drawing.Size(100, 23)
        Me.numHoras.TabIndex = 18
        Me.numHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numHoras.ThousandsSeparator = True
        '
        'gbxAgregarTrabajador
        '
        Me.gbxAgregarTrabajador.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.gbxAgregarTrabajador.Controls.Add(Me.txtAgregarNombreApellidos)
        Me.gbxAgregarTrabajador.Controls.Add(Me.numAgregarHoras)
        Me.gbxAgregarTrabajador.Controls.Add(Me.lblCompletarCampos)
        Me.gbxAgregarTrabajador.Controls.Add(Me.btnGuardarAgregarTrabajador)
        Me.gbxAgregarTrabajador.Controls.Add(Me.cbxAgregarModalidad)
        Me.gbxAgregarTrabajador.Controls.Add(Me.lblAgregarHoras)
        Me.gbxAgregarTrabajador.Controls.Add(Me.lblAgregarModalidad)
        Me.gbxAgregarTrabajador.Controls.Add(Me.lblAgregarNombre)
        Me.gbxAgregarTrabajador.Controls.Add(Me.btnCerrarAgregarTrabajador)
        Me.gbxAgregarTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxAgregarTrabajador.Location = New System.Drawing.Point(623, 444)
        Me.gbxAgregarTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.gbxAgregarTrabajador.Name = "gbxAgregarTrabajador"
        Me.gbxAgregarTrabajador.Padding = New System.Windows.Forms.Padding(4)
        Me.gbxAgregarTrabajador.Size = New System.Drawing.Size(428, 276)
        Me.gbxAgregarTrabajador.TabIndex = 19
        Me.gbxAgregarTrabajador.TabStop = False
        Me.gbxAgregarTrabajador.Text = "Agregar Trabajador"
        Me.gbxAgregarTrabajador.Visible = False
        '
        'numAgregarHoras
        '
        Me.numAgregarHoras.Location = New System.Drawing.Point(173, 163)
        Me.numAgregarHoras.Maximum = New Decimal(New Integer() {240, 0, 0, 0})
        Me.numAgregarHoras.Name = "numAgregarHoras"
        Me.numAgregarHoras.Size = New System.Drawing.Size(100, 23)
        Me.numAgregarHoras.TabIndex = 18
        Me.numAgregarHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.numAgregarHoras.ThousandsSeparator = True
        '
        'lblCompletarCampos
        '
        Me.lblCompletarCampos.AutoSize = True
        Me.lblCompletarCampos.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lblCompletarCampos.Location = New System.Drawing.Point(33, 37)
        Me.lblCompletarCampos.Name = "lblCompletarCampos"
        Me.lblCompletarCampos.Size = New System.Drawing.Size(342, 17)
        Me.lblCompletarCampos.TabIndex = 17
        Me.lblCompletarCampos.Text = "Por favor complete todos los campos del trabajador *"
        '
        'btnGuardarAgregarTrabajador
        '
        Me.btnGuardarAgregarTrabajador.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnGuardarAgregarTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarAgregarTrabajador.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnGuardarAgregarTrabajador.Location = New System.Drawing.Point(100, 218)
        Me.btnGuardarAgregarTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardarAgregarTrabajador.Name = "btnGuardarAgregarTrabajador"
        Me.btnGuardarAgregarTrabajador.Size = New System.Drawing.Size(100, 32)
        Me.btnGuardarAgregarTrabajador.TabIndex = 16
        Me.btnGuardarAgregarTrabajador.Text = "Guardar"
        Me.btnGuardarAgregarTrabajador.UseVisualStyleBackColor = False
        '
        'cbxAgregarModalidad
        '
        Me.cbxAgregarModalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAgregarModalidad.FormattingEnabled = True
        Me.cbxAgregarModalidad.Items.AddRange(New Object() {"Fijo", "Temporal"})
        Me.cbxAgregarModalidad.Location = New System.Drawing.Point(173, 117)
        Me.cbxAgregarModalidad.Name = "cbxAgregarModalidad"
        Me.cbxAgregarModalidad.Size = New System.Drawing.Size(200, 24)
        Me.cbxAgregarModalidad.TabIndex = 11
        '
        'lblAgregarHoras
        '
        Me.lblAgregarHoras.AutoSize = True
        Me.lblAgregarHoras.Location = New System.Drawing.Point(117, 165)
        Me.lblAgregarHoras.Name = "lblAgregarHoras"
        Me.lblAgregarHoras.Size = New System.Drawing.Size(50, 17)
        Me.lblAgregarHoras.TabIndex = 6
        Me.lblAgregarHoras.Text = "Horas:"
        '
        'lblAgregarModalidad
        '
        Me.lblAgregarModalidad.AutoSize = True
        Me.lblAgregarModalidad.Location = New System.Drawing.Point(90, 120)
        Me.lblAgregarModalidad.Name = "lblAgregarModalidad"
        Me.lblAgregarModalidad.Size = New System.Drawing.Size(77, 17)
        Me.lblAgregarModalidad.TabIndex = 5
        Me.lblAgregarModalidad.Text = "Modalidad:"
        '
        'lblAgregarNombre
        '
        Me.lblAgregarNombre.AutoSize = True
        Me.lblAgregarNombre.Location = New System.Drawing.Point(33, 76)
        Me.lblAgregarNombre.Name = "lblAgregarNombre"
        Me.lblAgregarNombre.Size = New System.Drawing.Size(134, 17)
        Me.lblAgregarNombre.TabIndex = 4
        Me.lblAgregarNombre.Text = "Nombre y Apellidos:"
        '
        'btnCerrarAgregarTrabajador
        '
        Me.btnCerrarAgregarTrabajador.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCerrarAgregarTrabajador.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarAgregarTrabajador.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCerrarAgregarTrabajador.Location = New System.Drawing.Point(226, 218)
        Me.btnCerrarAgregarTrabajador.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCerrarAgregarTrabajador.Name = "btnCerrarAgregarTrabajador"
        Me.btnCerrarAgregarTrabajador.Size = New System.Drawing.Size(100, 32)
        Me.btnCerrarAgregarTrabajador.TabIndex = 3
        Me.btnCerrarAgregarTrabajador.Text = "Cerrar"
        Me.btnCerrarAgregarTrabajador.UseVisualStyleBackColor = False
        '
        'txtAgregarNombreApellidos
        '
        Me.txtAgregarNombreApellidos.Location = New System.Drawing.Point(173, 73)
        Me.txtAgregarNombreApellidos.Name = "txtAgregarNombreApellidos"
        Me.txtAgregarNombreApellidos.Size = New System.Drawing.Size(200, 23)
        Me.txtAgregarNombreApellidos.TabIndex = 19
        '
        'lblIndicaciones
        '
        Me.lblIndicaciones.AutoSize = True
        Me.lblIndicaciones.Location = New System.Drawing.Point(27, 113)
        Me.lblIndicaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIndicaciones.Name = "lblIndicaciones"
        Me.lblIndicaciones.Size = New System.Drawing.Size(515, 374)
        Me.lblIndicaciones.TabIndex = 4
        Me.lblIndicaciones.Text = resources.GetString("lblIndicaciones.Text")
        '
        'frmRetoTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.gbxListaTrabajadores)
        Me.Controls.Add(Me.gbxAcercaDe)
        Me.Controls.Add(Me.gbxAgregarTrabajador)
        Me.Controls.Add(Me.gbxNominaTrabajadores)
        Me.Controls.Add(Me.gbxTipoPago)
        Me.Controls.Add(Me.gbxTipoCambio)
        Me.Controls.Add(Me.mnuRetoTecnico)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.mnuRetoTecnico
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmRetoTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reto Técnico - José Villanueva"
        Me.mnuRetoTecnico.ResumeLayout(False)
        Me.mnuRetoTecnico.PerformLayout()
        Me.gbxAcercaDe.ResumeLayout(False)
        Me.gbxAcercaDe.PerformLayout()
        Me.gbxTipoCambio.ResumeLayout(False)
        Me.gbxTipoCambio.PerformLayout()
        CType(Me.numTipoCambio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTipoPago.ResumeLayout(False)
        Me.gbxTipoPago.PerformLayout()
        CType(Me.numPagoTemporal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPagoFijo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxListaTrabajadores.ResumeLayout(False)
        Me.gbxListaTrabajadores.PerformLayout()
        CType(Me.dgvTrabajadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxNominaTrabajadores.ResumeLayout(False)
        Me.gbxNominaTrabajadores.PerformLayout()
        CType(Me.numHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxAgregarTrabajador.ResumeLayout(False)
        Me.gbxAgregarTrabajador.PerformLayout()
        CType(Me.numAgregarHoras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuRetoTecnico As MenuStrip
    Friend WithEvents TrabajadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarTrabajadorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaDeTrabajadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NóminaDeTrabajadoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDeCambioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TipoDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarProyectoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AcercaDeRetoTécnicoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gbxAcercaDe As GroupBox
    Friend WithEvents btnCerrarAcercaDe As Button
    Friend WithEvents lblFechaDesarrollo As Label
    Friend WithEvents lblParaEmpresa As Label
    Friend WithEvents lblDesarrollador As Label
    Friend WithEvents gbxTipoCambio As GroupBox
    Friend WithEvents numTipoCambio As NumericUpDown
    Friend WithEvents lblValorDolar As Label
    Friend WithEvents btnGuardarTipoCambio As Button
    Friend WithEvents btnEliminarTipoCambio As Button
    Friend WithEvents btnCerrarTipoCambio As Button
    Friend WithEvents gbxTipoPago As GroupBox
    Friend WithEvents numPagoTemporal As NumericUpDown
    Friend WithEvents lblPagoTemporal As Label
    Friend WithEvents btnCerrarTipoPago As Button
    Friend WithEvents btnGuardarTipoPago As Button
    Friend WithEvents numPagoFijo As NumericUpDown
    Friend WithEvents lblPagoFijo As Label
    Friend WithEvents gbxListaTrabajadores As GroupBox
    Friend WithEvents btnCerrarListaTrabajadores As Button
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicial As DateTimePicker
    Friend WithEvents lblFechaFinal As Label
    Friend WithEvents lblFechaInicial As Label
    Friend WithEvents dgvTrabajadores As DataGridView
    Friend WithEvents btnBuscarListaTrabajadores As Button
    Friend WithEvents dgFecha As DataGridViewTextBoxColumn
    Friend WithEvents dgNombreApellidos As DataGridViewTextBoxColumn
    Friend WithEvents dgModalidad As DataGridViewTextBoxColumn
    Friend WithEvents dgHoras As DataGridViewTextBoxColumn
    Friend WithEvents dgTipoCambio As DataGridViewTextBoxColumn
    Friend WithEvents dgPagoSoles As DataGridViewTextBoxColumn
    Friend WithEvents dgPagoDolares As DataGridViewTextBoxColumn
    Friend WithEvents gbxNominaTrabajadores As GroupBox
    Friend WithEvents btnCerrarNominaTrabajadores As Button
    Friend WithEvents cbxNombreApellidos As ComboBox
    Friend WithEvents lblPagoDolares As Label
    Friend WithEvents lblPagoSoles As Label
    Friend WithEvents lblTipoCambio As Label
    Friend WithEvents lblHoras As Label
    Friend WithEvents lblModalidad As Label
    Friend WithEvents lblNombreApellidos As Label
    Friend WithEvents cbxModalidad As ComboBox
    Friend WithEvents btnGuardarNominaTrabajador As Button
    Friend WithEvents txtPagoDolares As TextBox
    Friend WithEvents txtPagoSoles As TextBox
    Friend WithEvents txtTipoCambio As TextBox
    Friend WithEvents lblSeleccioneTrabajador As Label
    Friend WithEvents numHoras As NumericUpDown
    Friend WithEvents gbxAgregarTrabajador As GroupBox
    Friend WithEvents numAgregarHoras As NumericUpDown
    Friend WithEvents lblCompletarCampos As Label
    Friend WithEvents btnGuardarAgregarTrabajador As Button
    Friend WithEvents cbxAgregarModalidad As ComboBox
    Friend WithEvents lblAgregarHoras As Label
    Friend WithEvents lblAgregarModalidad As Label
    Friend WithEvents lblAgregarNombre As Label
    Friend WithEvents btnCerrarAgregarTrabajador As Button
    Friend WithEvents txtAgregarNombreApellidos As TextBox
    Friend WithEvents lblIndicaciones As Label
End Class

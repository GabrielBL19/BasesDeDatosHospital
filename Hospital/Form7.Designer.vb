<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        btnEliminarUtensilio = New Button()
        btnModificarUtensilio = New Button()
        btnAgregarUtensilio = New Button()
        grpDatosUtensilio = New GroupBox()
        btnBuscarUtensilio = New Button()
        txtSerialUtensilio = New TextBox()
        lblSerialUtensilio = New Label()
        lblCatUtensilio = New Label()
        txtDescripUtensilio = New TextBox()
        lblDescripUtensilio = New Label()
        txtPrecioUtensilio = New TextBox()
        lblPrecioUtensilio = New Label()
        txtNombreUtensilio = New TextBox()
        lblNombreUtensilio = New Label()
        txtIdMob = New TextBox()
        lblIdUtensilio = New Label()
        lblNombFormUtensilios = New Label()
        lblMatUtensilio = New Label()
        dtgUtensilios = New DataGridView()
        cbxMatUtensilio = New ComboBox()
        cbxCatUtensilio = New ComboBox()
        grpDatosUtensilio.SuspendLayout()
        CType(dtgUtensilios, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnEliminarUtensilio
        ' 
        btnEliminarUtensilio.Location = New Point(326, 390)
        btnEliminarUtensilio.Name = "btnEliminarUtensilio"
        btnEliminarUtensilio.Size = New Size(94, 29)
        btnEliminarUtensilio.TabIndex = 9
        btnEliminarUtensilio.Text = "Eliminar"
        btnEliminarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' btnModificarUtensilio
        ' 
        btnModificarUtensilio.Location = New Point(178, 390)
        btnModificarUtensilio.Name = "btnModificarUtensilio"
        btnModificarUtensilio.Size = New Size(94, 29)
        btnModificarUtensilio.TabIndex = 8
        btnModificarUtensilio.Text = "Modificar"
        btnModificarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarUtensilio
        ' 
        btnAgregarUtensilio.Location = New Point(27, 390)
        btnAgregarUtensilio.Name = "btnAgregarUtensilio"
        btnAgregarUtensilio.Size = New Size(94, 29)
        btnAgregarUtensilio.TabIndex = 7
        btnAgregarUtensilio.Text = "Agregar"
        btnAgregarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' grpDatosUtensilio
        ' 
        grpDatosUtensilio.Controls.Add(cbxCatUtensilio)
        grpDatosUtensilio.Controls.Add(cbxMatUtensilio)
        grpDatosUtensilio.Controls.Add(lblMatUtensilio)
        grpDatosUtensilio.Controls.Add(btnBuscarUtensilio)
        grpDatosUtensilio.Controls.Add(txtSerialUtensilio)
        grpDatosUtensilio.Controls.Add(lblSerialUtensilio)
        grpDatosUtensilio.Controls.Add(lblCatUtensilio)
        grpDatosUtensilio.Controls.Add(txtDescripUtensilio)
        grpDatosUtensilio.Controls.Add(lblDescripUtensilio)
        grpDatosUtensilio.Controls.Add(txtPrecioUtensilio)
        grpDatosUtensilio.Controls.Add(lblPrecioUtensilio)
        grpDatosUtensilio.Controls.Add(txtNombreUtensilio)
        grpDatosUtensilio.Controls.Add(lblNombreUtensilio)
        grpDatosUtensilio.Controls.Add(txtIdMob)
        grpDatosUtensilio.Controls.Add(lblIdUtensilio)
        grpDatosUtensilio.Location = New Point(21, 81)
        grpDatosUtensilio.Name = "grpDatosUtensilio"
        grpDatosUtensilio.Size = New Size(432, 288)
        grpDatosUtensilio.TabIndex = 6
        grpDatosUtensilio.TabStop = False
        grpDatosUtensilio.Text = "Información de Utensilios"
        ' 
        ' btnBuscarUtensilio
        ' 
        btnBuscarUtensilio.Location = New Point(326, 28)
        btnBuscarUtensilio.Name = "btnBuscarUtensilio"
        btnBuscarUtensilio.Size = New Size(73, 29)
        btnBuscarUtensilio.TabIndex = 9
        btnBuscarUtensilio.Text = "Buscar"
        btnBuscarUtensilio.UseVisualStyleBackColor = True
        ' 
        ' txtSerialUtensilio
        ' 
        txtSerialUtensilio.Location = New Point(55, 244)
        txtSerialUtensilio.Name = "txtSerialUtensilio"
        txtSerialUtensilio.Size = New Size(196, 27)
        txtSerialUtensilio.TabIndex = 7
        ' 
        ' lblSerialUtensilio
        ' 
        lblSerialUtensilio.AutoSize = True
        lblSerialUtensilio.Location = New Point(6, 251)
        lblSerialUtensilio.Name = "lblSerialUtensilio"
        lblSerialUtensilio.Size = New Size(49, 20)
        lblSerialUtensilio.TabIndex = 6
        lblSerialUtensilio.Text = "Serial:"
        ' 
        ' lblCatUtensilio
        ' 
        lblCatUtensilio.AutoSize = True
        lblCatUtensilio.Location = New Point(6, 108)
        lblCatUtensilio.Name = "lblCatUtensilio"
        lblCatUtensilio.Size = New Size(77, 20)
        lblCatUtensilio.TabIndex = 2
        lblCatUtensilio.Text = "Categoría:"
        ' 
        ' txtDescripUtensilio
        ' 
        txtDescripUtensilio.Location = New Point(99, 207)
        txtDescripUtensilio.Name = "txtDescripUtensilio"
        txtDescripUtensilio.Size = New Size(181, 27)
        txtDescripUtensilio.TabIndex = 2
        ' 
        ' lblDescripUtensilio
        ' 
        lblDescripUtensilio.AutoSize = True
        lblDescripUtensilio.Location = New Point(6, 215)
        lblDescripUtensilio.Name = "lblDescripUtensilio"
        lblDescripUtensilio.Size = New Size(90, 20)
        lblDescripUtensilio.TabIndex = 2
        lblDescripUtensilio.Text = "Descripción:"
        ' 
        ' txtPrecioUtensilio
        ' 
        txtPrecioUtensilio.Location = New Point(65, 174)
        txtPrecioUtensilio.Name = "txtPrecioUtensilio"
        txtPrecioUtensilio.Size = New Size(186, 27)
        txtPrecioUtensilio.TabIndex = 5
        ' 
        ' lblPrecioUtensilio
        ' 
        lblPrecioUtensilio.AutoSize = True
        lblPrecioUtensilio.Location = New Point(6, 181)
        lblPrecioUtensilio.Name = "lblPrecioUtensilio"
        lblPrecioUtensilio.Size = New Size(53, 20)
        lblPrecioUtensilio.TabIndex = 4
        lblPrecioUtensilio.Text = "Precio:"
        ' 
        ' txtNombreUtensilio
        ' 
        txtNombreUtensilio.Location = New Point(79, 64)
        txtNombreUtensilio.Name = "txtNombreUtensilio"
        txtNombreUtensilio.Size = New Size(241, 27)
        txtNombreUtensilio.TabIndex = 2
        ' 
        ' lblNombreUtensilio
        ' 
        lblNombreUtensilio.AutoSize = True
        lblNombreUtensilio.Location = New Point(6, 71)
        lblNombreUtensilio.Name = "lblNombreUtensilio"
        lblNombreUtensilio.Size = New Size(67, 20)
        lblNombreUtensilio.TabIndex = 3
        lblNombreUtensilio.Text = "Nombre:"
        ' 
        ' txtIdMob
        ' 
        txtIdMob.Location = New Point(120, 28)
        txtIdMob.Name = "txtIdMob"
        txtIdMob.Size = New Size(200, 27)
        txtIdMob.TabIndex = 2
        ' 
        ' lblIdUtensilio
        ' 
        lblIdUtensilio.AutoSize = True
        lblIdUtensilio.Location = New Point(6, 35)
        lblIdUtensilio.Name = "lblIdUtensilio"
        lblIdUtensilio.Size = New Size(114, 20)
        lblIdUtensilio.TabIndex = 2
        lblIdUtensilio.Text = "ID del Utensilio:"
        ' 
        ' lblNombFormUtensilios
        ' 
        lblNombFormUtensilios.AutoSize = True
        lblNombFormUtensilios.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormUtensilios.Location = New Point(491, 9)
        lblNombFormUtensilios.Name = "lblNombFormUtensilios"
        lblNombFormUtensilios.Size = New Size(340, 41)
        lblNombFormUtensilios.TabIndex = 5
        lblNombFormUtensilios.Text = "Formulario de Utensilios"
        ' 
        ' lblMatUtensilio
        ' 
        lblMatUtensilio.AutoSize = True
        lblMatUtensilio.Location = New Point(6, 145)
        lblMatUtensilio.Name = "lblMatUtensilio"
        lblMatUtensilio.Size = New Size(67, 20)
        lblMatUtensilio.TabIndex = 10
        lblMatUtensilio.Text = "Material:"
        ' 
        ' dtgUtensilios
        ' 
        dtgUtensilios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgUtensilios.Location = New Point(491, 81)
        dtgUtensilios.Name = "dtgUtensilios"
        dtgUtensilios.RowHeadersWidth = 51
        dtgUtensilios.Size = New Size(825, 324)
        dtgUtensilios.TabIndex = 10
        ' 
        ' cbxMatUtensilio
        ' 
        cbxMatUtensilio.FormattingEnabled = True
        cbxMatUtensilio.Location = New Point(79, 137)
        cbxMatUtensilio.Name = "cbxMatUtensilio"
        cbxMatUtensilio.Size = New Size(201, 28)
        cbxMatUtensilio.TabIndex = 11
        ' 
        ' cbxCatUtensilio
        ' 
        cbxCatUtensilio.FormattingEnabled = True
        cbxCatUtensilio.Location = New Point(89, 100)
        cbxCatUtensilio.Name = "cbxCatUtensilio"
        cbxCatUtensilio.Size = New Size(206, 28)
        cbxCatUtensilio.TabIndex = 12
        ' 
        ' Form7
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1347, 458)
        Controls.Add(dtgUtensilios)
        Controls.Add(btnEliminarUtensilio)
        Controls.Add(btnModificarUtensilio)
        Controls.Add(btnAgregarUtensilio)
        Controls.Add(grpDatosUtensilio)
        Controls.Add(lblNombFormUtensilios)
        Name = "Form7"
        Text = "Form7"
        grpDatosUtensilio.ResumeLayout(False)
        grpDatosUtensilio.PerformLayout()
        CType(dtgUtensilios, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEliminarUtensilio As Button
    Friend WithEvents btnModificarUtensilio As Button
    Friend WithEvents btnAgregarUtensilio As Button
    Friend WithEvents grpDatosUtensilio As GroupBox
    Friend WithEvents btnBuscarUtensilio As Button
    Friend WithEvents txtSerialUtensilio As TextBox
    Friend WithEvents lblSerialUtensilio As Label
    Friend WithEvents lblCatUtensilio As Label
    Friend WithEvents txtDescripUtensilio As TextBox
    Friend WithEvents lblDescripUtensilio As Label
    Friend WithEvents txtPrecioUtensilio As TextBox
    Friend WithEvents lblPrecioUtensilio As Label
    Friend WithEvents txtNombreUtensilio As TextBox
    Friend WithEvents lblNombreUtensilio As Label
    Friend WithEvents txtIdMob As TextBox
    Friend WithEvents lblIdUtensilio As Label
    Friend WithEvents lblNombFormUtensilios As Label
    Friend WithEvents lblMatUtensilio As Label
    Friend WithEvents cbxCatUtensilio As ComboBox
    Friend WithEvents cbxMatUtensilio As ComboBox
    Friend WithEvents dtgUtensilios As DataGridView
End Class

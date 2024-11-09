<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Me.dtgEquipoLimp = New DataGridView()
        btnEliminarEquipo = New Button()
        btnModificarEquipo = New Button()
        btnAgregarEquipo = New Button()
        grpDatosUtensilio = New GroupBox()
        cbxCatEquipo = New ComboBox()
        btnBuscarEquipo = New Button()
        lblCatEquipo = New Label()
        Me.txtDescripEquipo = New TextBox()
        Me.lblDescripEquipo = New Label()
        Me.txtPrecioEquipo = New TextBox()
        lblPrecioEquipo = New Label()
        txtNombreEquipo = New TextBox()
        lblNombreEquipo = New Label()
        txtIdEquipo = New TextBox()
        lblIdUtensilio = New Label()
        lblNombFormEquipoL = New Label()
        CType(Me.dtgEquipoLimp, ComponentModel.ISupportInitialize).BeginInit()
        grpDatosUtensilio.SuspendLayout()
        SuspendLayout()
        ' 
        ' dtgEquipoLimp
        ' 
        Me.dtgEquipoLimp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgEquipoLimp.Location = New Point(484, 81)
        Me.dtgEquipoLimp.Name = "dtgEquipoLimp"
        Me.dtgEquipoLimp.RowHeadersWidth = 51
        Me.dtgEquipoLimp.Size = New Size(825, 324)
        Me.dtgEquipoLimp.TabIndex = 16
        ' 
        ' btnEliminarEquipo
        ' 
        btnEliminarEquipo.Location = New Point(319, 340)
        btnEliminarEquipo.Name = "btnEliminarEquipo"
        btnEliminarEquipo.Size = New Size(94, 29)
        btnEliminarEquipo.TabIndex = 15
        btnEliminarEquipo.Text = "Eliminar"
        btnEliminarEquipo.UseVisualStyleBackColor = True
        ' 
        ' btnModificarEquipo
        ' 
        btnModificarEquipo.Location = New Point(171, 340)
        btnModificarEquipo.Name = "btnModificarEquipo"
        btnModificarEquipo.Size = New Size(94, 29)
        btnModificarEquipo.TabIndex = 14
        btnModificarEquipo.Text = "Modificar"
        btnModificarEquipo.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarEquipo
        ' 
        btnAgregarEquipo.Location = New Point(29, 340)
        btnAgregarEquipo.Name = "btnAgregarEquipo"
        btnAgregarEquipo.Size = New Size(94, 29)
        btnAgregarEquipo.TabIndex = 13
        btnAgregarEquipo.Text = "Agregar"
        btnAgregarEquipo.UseVisualStyleBackColor = True
        ' 
        ' grpDatosUtensilio
        ' 
        grpDatosUtensilio.Controls.Add(cbxCatEquipo)
        grpDatosUtensilio.Controls.Add(btnBuscarEquipo)
        grpDatosUtensilio.Controls.Add(lblCatEquipo)
        grpDatosUtensilio.Controls.Add(Me.txtDescripEquipo)
        grpDatosUtensilio.Controls.Add(Me.lblDescripEquipo)
        grpDatosUtensilio.Controls.Add(Me.txtPrecioEquipo)
        grpDatosUtensilio.Controls.Add(lblPrecioEquipo)
        grpDatosUtensilio.Controls.Add(txtNombreEquipo)
        grpDatosUtensilio.Controls.Add(lblNombreEquipo)
        grpDatosUtensilio.Controls.Add(txtIdEquipo)
        grpDatosUtensilio.Controls.Add(lblIdUtensilio)
        grpDatosUtensilio.Location = New Point(14, 81)
        grpDatosUtensilio.Name = "grpDatosUtensilio"
        grpDatosUtensilio.Size = New Size(432, 230)
        grpDatosUtensilio.TabIndex = 12
        grpDatosUtensilio.TabStop = False
        grpDatosUtensilio.Text = "Información de Rquipo de Limpieza"
        ' 
        ' cbxCatEquipo
        ' 
        cbxCatEquipo.FormattingEnabled = True
        cbxCatEquipo.Location = New Point(89, 100)
        cbxCatEquipo.Name = "cbxCatEquipo"
        cbxCatEquipo.Size = New Size(206, 28)
        cbxCatEquipo.TabIndex = 12
        ' 
        ' btnBuscarEquipo
        ' 
        btnBuscarEquipo.Location = New Point(326, 28)
        btnBuscarEquipo.Name = "btnBuscarEquipo"
        btnBuscarEquipo.Size = New Size(73, 29)
        btnBuscarEquipo.TabIndex = 9
        btnBuscarEquipo.Text = "Buscar"
        btnBuscarEquipo.UseVisualStyleBackColor = True
        ' 
        ' lblCatEquipo
        ' 
        lblCatEquipo.AutoSize = True
        lblCatEquipo.Location = New Point(6, 108)
        lblCatEquipo.Name = "lblCatEquipo"
        lblCatEquipo.Size = New Size(77, 20)
        lblCatEquipo.TabIndex = 2
        lblCatEquipo.Text = "Categoría:"
        ' 
        ' txtDescripEquipo
        ' 
        Me.txtDescripEquipo.Location = New Point(102, 173)
        Me.txtDescripEquipo.Name = "txtDescripEquipo"
        Me.txtDescripEquipo.Size = New Size(181, 27)
        Me.txtDescripEquipo.TabIndex = 2
        ' 
        ' lblDescripEquipo
        ' 
        Me.lblDescripEquipo.AutoSize = True
        Me.lblDescripEquipo.Location = New Point(6, 180)
        Me.lblDescripEquipo.Name = "lblDescripEquipo"
        Me.lblDescripEquipo.Size = New Size(90, 20)
        Me.lblDescripEquipo.TabIndex = 2
        Me.lblDescripEquipo.Text = "Descripción:"
        ' 
        ' txtPrecioEquipo
        ' 
        Me.txtPrecioEquipo.Location = New Point(65, 138)
        Me.txtPrecioEquipo.Name = "txtPrecioEquipo"
        Me.txtPrecioEquipo.Size = New Size(186, 27)
        Me.txtPrecioEquipo.TabIndex = 5
        ' 
        ' lblPrecioEquipo
        ' 
        lblPrecioEquipo.AutoSize = True
        lblPrecioEquipo.Location = New Point(6, 145)
        lblPrecioEquipo.Name = "lblPrecioEquipo"
        lblPrecioEquipo.Size = New Size(53, 20)
        lblPrecioEquipo.TabIndex = 4
        lblPrecioEquipo.Text = "Precio:"
        ' 
        ' txtNombreEquipo
        ' 
        txtNombreEquipo.Location = New Point(79, 64)
        txtNombreEquipo.Name = "txtNombreEquipo"
        txtNombreEquipo.Size = New Size(241, 27)
        txtNombreEquipo.TabIndex = 2
        ' 
        ' lblNombreEquipo
        ' 
        lblNombreEquipo.AutoSize = True
        lblNombreEquipo.Location = New Point(6, 71)
        lblNombreEquipo.Name = "lblNombreEquipo"
        lblNombreEquipo.Size = New Size(67, 20)
        lblNombreEquipo.TabIndex = 3
        lblNombreEquipo.Text = "Nombre:"
        ' 
        ' txtIdEquipo
        ' 
        txtIdEquipo.Location = New Point(115, 28)
        txtIdEquipo.Name = "txtIdEquipo"
        txtIdEquipo.Size = New Size(200, 27)
        txtIdEquipo.TabIndex = 2
        ' 
        ' lblIdUtensilio
        ' 
        lblIdUtensilio.AutoSize = True
        lblIdUtensilio.Location = New Point(6, 35)
        lblIdUtensilio.Name = "lblIdUtensilio"
        lblIdUtensilio.Size = New Size(103, 20)
        lblIdUtensilio.TabIndex = 2
        lblIdUtensilio.Text = "ID del Equipo:"
        ' 
        ' lblNombFormEquipoL
        ' 
        lblNombFormEquipoL.AutoSize = True
        lblNombFormEquipoL.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormEquipoL.Location = New Point(464, 9)
        lblNombFormEquipoL.Name = "lblNombFormEquipoL"
        lblNombFormEquipoL.Size = New Size(471, 41)
        lblNombFormEquipoL.TabIndex = 11
        lblNombFormEquipoL.Text = "Formulario de Equipo de Limpieza"
        ' 
        ' Form8
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1317, 430)
        Controls.Add(Me.dtgEquipoLimp)
        Controls.Add(btnEliminarEquipo)
        Controls.Add(btnModificarEquipo)
        Controls.Add(btnAgregarEquipo)
        Controls.Add(grpDatosUtensilio)
        Controls.Add(lblNombFormEquipoL)
        Name = "Form8"
        Text = "Form8"
        CType(Me.dtgEquipoLimp, ComponentModel.ISupportInitialize).EndInit()
        grpDatosUtensilio.ResumeLayout(False)
        grpDatosUtensilio.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dtgUtensilios As DataGridView
    Friend WithEvents btnEliminarEquipo As Button
    Friend WithEvents btnModificarEquipo As Button
    Friend WithEvents btnAgregarEquipo As Button
    Friend WithEvents grpDatosUtensilio As GroupBox
    Friend WithEvents cbxCatEquipo As ComboBox
    Friend WithEvents cbxMatUtensilio As ComboBox
    Friend WithEvents lblMatUtensilio As Label
    Friend WithEvents btnBuscarEquipo As Button
    Friend WithEvents txtSerialUtensilio As TextBox
    Friend WithEvents lblSerialUtensilio As Label
    Friend WithEvents lblCatEquipo As Label
    Friend WithEvents txtDescripUtensilio As TextBox
    Friend WithEvents lblDescripUtensilio As Label
    Friend WithEvents txtPrecioUtensilio As TextBox
    Friend WithEvents lblPrecioEquipo As Label
    Friend WithEvents txtNombreEquipo As TextBox
    Friend WithEvents lblNombreEquipo As Label
    Friend WithEvents txtIdEquipo As TextBox
    Friend WithEvents lblIdUtensilio As Label
    Friend WithEvents lblNombFormEquipoL As Label
End Class

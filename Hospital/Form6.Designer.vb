<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        lblNombFormMob = New Label()
        grpDatosMob = New GroupBox()
        lblIdMob = New Label()
        txtIdMob = New TextBox()
        lblNombreMob = New Label()
        txtNombreMob = New TextBox()
        lblPrecioMob = New Label()
        txtPrecioMob = New TextBox()
        lblDescripMob = New Label()
        txtDescripMob = New TextBox()
        lblCatMob = New Label()
        lblSerialMob = New Label()
        txtSerialMob = New TextBox()
        btnAgregarMob = New Button()
        btnModificarMob = New Button()
        btnEliminarMob = New Button()
        btnBuscarMob = New Button()
        dtgMobiliario = New DataGridView()
        cbxCatMobiliario = New ComboBox()
        grpDatosMob.SuspendLayout()
        CType(dtgMobiliario, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblNombFormMob
        ' 
        lblNombFormMob.AutoSize = True
        lblNombFormMob.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormMob.Location = New Point(492, 9)
        lblNombFormMob.Name = "lblNombFormMob"
        lblNombFormMob.Size = New Size(345, 41)
        lblNombFormMob.TabIndex = 0
        lblNombFormMob.Text = "Formulario de Mobiliario"
        ' 
        ' grpDatosMob
        ' 
        grpDatosMob.Controls.Add(cbxCatMobiliario)
        grpDatosMob.Controls.Add(btnBuscarMob)
        grpDatosMob.Controls.Add(txtSerialMob)
        grpDatosMob.Controls.Add(lblSerialMob)
        grpDatosMob.Controls.Add(lblCatMob)
        grpDatosMob.Controls.Add(txtDescripMob)
        grpDatosMob.Controls.Add(lblDescripMob)
        grpDatosMob.Controls.Add(txtPrecioMob)
        grpDatosMob.Controls.Add(lblPrecioMob)
        grpDatosMob.Controls.Add(txtNombreMob)
        grpDatosMob.Controls.Add(lblNombreMob)
        grpDatosMob.Controls.Add(txtIdMob)
        grpDatosMob.Controls.Add(lblIdMob)
        grpDatosMob.Location = New Point(12, 77)
        grpDatosMob.Name = "grpDatosMob"
        grpDatosMob.Size = New Size(424, 249)
        grpDatosMob.TabIndex = 1
        grpDatosMob.TabStop = False
        grpDatosMob.Text = "Información de Mobiliario"
        ' 
        ' lblIdMob
        ' 
        lblIdMob.AutoSize = True
        lblIdMob.Location = New Point(6, 35)
        lblIdMob.Name = "lblIdMob"
        lblIdMob.Size = New Size(108, 20)
        lblIdMob.TabIndex = 2
        lblIdMob.Text = "ID del Artículo:"
        ' 
        ' txtIdMob
        ' 
        txtIdMob.Location = New Point(120, 28)
        txtIdMob.Name = "txtIdMob"
        txtIdMob.Size = New Size(200, 27)
        txtIdMob.TabIndex = 2
        ' 
        ' lblNombreMob
        ' 
        lblNombreMob.AutoSize = True
        lblNombreMob.Location = New Point(6, 71)
        lblNombreMob.Name = "lblNombreMob"
        lblNombreMob.Size = New Size(67, 20)
        lblNombreMob.TabIndex = 3
        lblNombreMob.Text = "Nombre:"
        ' 
        ' txtNombreMob
        ' 
        txtNombreMob.Location = New Point(79, 64)
        txtNombreMob.Name = "txtNombreMob"
        txtNombreMob.Size = New Size(241, 27)
        txtNombreMob.TabIndex = 2
        ' 
        ' lblPrecioMob
        ' 
        lblPrecioMob.AutoSize = True
        lblPrecioMob.Location = New Point(6, 145)
        lblPrecioMob.Name = "lblPrecioMob"
        lblPrecioMob.Size = New Size(53, 20)
        lblPrecioMob.TabIndex = 4
        lblPrecioMob.Text = "Precio:"
        ' 
        ' txtPrecioMob
        ' 
        txtPrecioMob.Location = New Point(65, 138)
        txtPrecioMob.Name = "txtPrecioMob"
        txtPrecioMob.Size = New Size(186, 27)
        txtPrecioMob.TabIndex = 5
        ' 
        ' lblDescripMob
        ' 
        lblDescripMob.AutoSize = True
        lblDescripMob.Location = New Point(6, 179)
        lblDescripMob.Name = "lblDescripMob"
        lblDescripMob.Size = New Size(90, 20)
        lblDescripMob.TabIndex = 2
        lblDescripMob.Text = "Descripción:"
        ' 
        ' txtDescripMob
        ' 
        txtDescripMob.Location = New Point(102, 172)
        txtDescripMob.Name = "txtDescripMob"
        txtDescripMob.Size = New Size(181, 27)
        txtDescripMob.TabIndex = 2
        ' 
        ' lblCatMob
        ' 
        lblCatMob.AutoSize = True
        lblCatMob.Location = New Point(6, 108)
        lblCatMob.Name = "lblCatMob"
        lblCatMob.Size = New Size(77, 20)
        lblCatMob.TabIndex = 2
        lblCatMob.Text = "Categoría:"
        ' 
        ' lblSerialMob
        ' 
        lblSerialMob.AutoSize = True
        lblSerialMob.Location = New Point(6, 216)
        lblSerialMob.Name = "lblSerialMob"
        lblSerialMob.Size = New Size(49, 20)
        lblSerialMob.TabIndex = 6
        lblSerialMob.Text = "Serial:"
        ' 
        ' txtSerialMob
        ' 
        txtSerialMob.Location = New Point(58, 209)
        txtSerialMob.Name = "txtSerialMob"
        txtSerialMob.Size = New Size(196, 27)
        txtSerialMob.TabIndex = 7
        ' 
        ' btnAgregarMob
        ' 
        btnAgregarMob.Location = New Point(32, 349)
        btnAgregarMob.Name = "btnAgregarMob"
        btnAgregarMob.Size = New Size(94, 29)
        btnAgregarMob.TabIndex = 2
        btnAgregarMob.Text = "Agregar"
        btnAgregarMob.UseVisualStyleBackColor = True
        ' 
        ' btnModificarMob
        ' 
        btnModificarMob.Location = New Point(169, 349)
        btnModificarMob.Name = "btnModificarMob"
        btnModificarMob.Size = New Size(94, 29)
        btnModificarMob.TabIndex = 3
        btnModificarMob.Text = "Modificar"
        btnModificarMob.UseVisualStyleBackColor = True
        ' 
        ' btnEliminarMob
        ' 
        btnEliminarMob.Location = New Point(317, 349)
        btnEliminarMob.Name = "btnEliminarMob"
        btnEliminarMob.Size = New Size(94, 29)
        btnEliminarMob.TabIndex = 4
        btnEliminarMob.Text = "Eliminar"
        btnEliminarMob.UseVisualStyleBackColor = True
        ' 
        ' btnBuscarMob
        ' 
        btnBuscarMob.Location = New Point(326, 28)
        btnBuscarMob.Name = "btnBuscarMob"
        btnBuscarMob.Size = New Size(73, 29)
        btnBuscarMob.TabIndex = 9
        btnBuscarMob.Text = "Buscar"
        btnBuscarMob.UseVisualStyleBackColor = True
        ' 
        ' dtgMobiliario
        ' 
        dtgMobiliario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dtgMobiliario.Location = New Point(469, 77)
        dtgMobiliario.Name = "dtgMobiliario"
        dtgMobiliario.RowHeadersWidth = 51
        dtgMobiliario.Size = New Size(827, 303)
        dtgMobiliario.TabIndex = 5
        ' 
        ' cbxCatMobiliario
        ' 
        cbxCatMobiliario.FormattingEnabled = True
        cbxCatMobiliario.Location = New Point(89, 100)
        cbxCatMobiliario.Name = "cbxCatMobiliario"
        cbxCatMobiliario.Size = New Size(194, 28)
        cbxCatMobiliario.TabIndex = 10
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1320, 476)
        Controls.Add(dtgMobiliario)
        Controls.Add(btnEliminarMob)
        Controls.Add(btnModificarMob)
        Controls.Add(btnAgregarMob)
        Controls.Add(grpDatosMob)
        Controls.Add(lblNombFormMob)
        Name = "Form6"
        Text = "Form6"
        grpDatosMob.ResumeLayout(False)
        grpDatosMob.PerformLayout()
        CType(dtgMobiliario, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblNombFormMob As Label
    Friend WithEvents grpDatosMob As GroupBox
    Friend WithEvents lblNombreMob As Label
    Friend WithEvents txtIdMob As TextBox
    Friend WithEvents lblIdMob As Label
    Friend WithEvents txtNombreMob As TextBox
    Friend WithEvents lblPrecioMob As Label
    Friend WithEvents lblDescripMob As Label
    Friend WithEvents txtPrecioMob As TextBox
    Friend WithEvents txtSerialMob As TextBox
    Friend WithEvents lblSerialMob As Label
    Friend WithEvents lblCatMob As Label
    Friend WithEvents txtDescripMob As TextBox
    Friend WithEvents btnBuscarMob As Button
    Friend WithEvents btnAgregarMob As Button
    Friend WithEvents btnModificarMob As Button
    Friend WithEvents btnEliminarMob As Button
    Friend WithEvents cbxCatMobiliario As ComboBox
    Friend WithEvents dtgMobiliario As DataGridView
End Class

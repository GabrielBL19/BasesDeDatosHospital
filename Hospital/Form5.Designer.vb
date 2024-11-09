<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        btnElimEmp = New Button()
        btnModificarEmp = New Button()
        btnAgregarEmp = New Button()
        grpDatosProfEmp = New GroupBox()
        cbxCargoEmp = New ComboBox()
        lblCargoEmp = New Label()
        grpEstadoEmp = New GroupBox()
        rdbInactivoEmp = New RadioButton()
        rdbActivoEmp = New RadioButton()
        txtSueldoEmp = New TextBox()
        lblSueldoEmp = New Label()
        grpDatosEnf = New GroupBox()
        btnBuscEmp = New Button()
        cbxEstadoCivEmp = New ComboBox()
        lblEstadoCivEmp = New Label()
        mskTelEmp = New MaskedTextBox()
        lblTelefonoEmp = New Label()
        txtCorreoEmp = New TextBox()
        lblCorreoEmp = New Label()
        txtDirecEmp = New TextBox()
        lblDirecEmp = New Label()
        grpGeneroEmp = New GroupBox()
        rdbFemeninoEmp = New RadioButton()
        rdbMasculinoEmp = New RadioButton()
        txtEdadEmp = New TextBox()
        lblEdadEmp = New Label()
        dtpFechaNacEmp = New DateTimePicker()
        lblFechaNacEmp = New Label()
        txtApeEmp = New TextBox()
        lblApeEmp = New Label()
        txtNombEmp = New TextBox()
        lblNombEmp = New Label()
        mskIdentEmp = New MaskedTextBox()
        lblIdentEmp = New Label()
        lblNombFormEmp = New Label()
        grpDatosProfEmp.SuspendLayout()
        grpEstadoEmp.SuspendLayout()
        grpDatosEnf.SuspendLayout()
        grpGeneroEmp.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnElimEmp
        ' 
        btnElimEmp.Location = New Point(2700, 1015)
        btnElimEmp.Margin = New Padding(9)
        btnElimEmp.Name = "btnElimEmp"
        btnElimEmp.Size = New Size(270, 83)
        btnElimEmp.TabIndex = 17
        btnElimEmp.Text = "Eliminar"
        btnElimEmp.UseVisualStyleBackColor = True
        ' 
        ' btnModificarEmp
        ' 
        btnModificarEmp.Location = New Point(2263, 1012)
        btnModificarEmp.Margin = New Padding(9)
        btnModificarEmp.Name = "btnModificarEmp"
        btnModificarEmp.Size = New Size(270, 83)
        btnModificarEmp.TabIndex = 16
        btnModificarEmp.Text = "Actualizar"
        btnModificarEmp.UseVisualStyleBackColor = True
        ' 
        ' btnAgregarEmp
        ' 
        btnAgregarEmp.Location = New Point(1774, 1012)
        btnAgregarEmp.Margin = New Padding(9)
        btnAgregarEmp.Name = "btnAgregarEmp"
        btnAgregarEmp.Size = New Size(270, 83)
        btnAgregarEmp.TabIndex = 15
        btnAgregarEmp.Text = "Agregar"
        btnAgregarEmp.UseVisualStyleBackColor = True
        ' 
        ' grpDatosProfEmp
        ' 
        grpDatosProfEmp.Controls.Add(cbxCargoEmp)
        grpDatosProfEmp.Controls.Add(lblCargoEmp)
        grpDatosProfEmp.Controls.Add(grpEstadoEmp)
        grpDatosProfEmp.Controls.Add(txtSueldoEmp)
        grpDatosProfEmp.Controls.Add(lblSueldoEmp)
        grpDatosProfEmp.Location = New Point(1877, 228)
        grpDatosProfEmp.Margin = New Padding(9)
        grpDatosProfEmp.Name = "grpDatosProfEmp"
        grpDatosProfEmp.Padding = New Padding(9)
        grpDatosProfEmp.Size = New Size(1092, 470)
        grpDatosProfEmp.TabIndex = 14
        grpDatosProfEmp.TabStop = False
        grpDatosProfEmp.Text = "Datos Profesionales"
        ' 
        ' cbxCargoEmp
        ' 
        cbxCargoEmp.FormattingEnabled = True
        cbxCargoEmp.Items.AddRange(New Object() {"Director del Hospital", "Subdirector Médico", "Gerente de RRHH", "Secretario (a)", "Recepcionista"})
        cbxCargoEmp.Location = New Point(184, 74)
        cbxCargoEmp.Margin = New Padding(9)
        cbxCargoEmp.Name = "cbxCargoEmp"
        cbxCargoEmp.Size = New Size(427, 65)
        cbxCargoEmp.TabIndex = 8
        ' 
        ' lblCargoEmp
        ' 
        lblCargoEmp.AutoSize = True
        lblCargoEmp.Location = New Point(17, 91)
        lblCargoEmp.Margin = New Padding(9, 0, 9, 0)
        lblCargoEmp.Name = "lblCargoEmp"
        lblCargoEmp.Size = New Size(146, 57)
        lblCargoEmp.TabIndex = 7
        lblCargoEmp.Text = "Cargo:"
        ' 
        ' grpEstadoEmp
        ' 
        grpEstadoEmp.Controls.Add(rdbInactivoEmp)
        grpEstadoEmp.Controls.Add(rdbActivoEmp)
        grpEstadoEmp.Location = New Point(285, 285)
        grpEstadoEmp.Margin = New Padding(9)
        grpEstadoEmp.Name = "grpEstadoEmp"
        grpEstadoEmp.Padding = New Padding(9)
        grpEstadoEmp.Size = New Size(494, 142)
        grpEstadoEmp.TabIndex = 6
        grpEstadoEmp.TabStop = False
        grpEstadoEmp.Text = "Estado"
        ' 
        ' rdbInactivoEmp
        ' 
        rdbInactivoEmp.AutoSize = True
        rdbInactivoEmp.Location = New Point(242, 57)
        rdbInactivoEmp.Margin = New Padding(9)
        rdbInactivoEmp.Name = "rdbInactivoEmp"
        rdbInactivoEmp.Size = New Size(213, 61)
        rdbInactivoEmp.TabIndex = 1
        rdbInactivoEmp.TabStop = True
        rdbInactivoEmp.Text = "Inactivo"
        rdbInactivoEmp.UseVisualStyleBackColor = True
        ' 
        ' rdbActivoEmp
        ' 
        rdbActivoEmp.AutoSize = True
        rdbActivoEmp.Location = New Point(17, 57)
        rdbActivoEmp.Margin = New Padding(9)
        rdbActivoEmp.Name = "rdbActivoEmp"
        rdbActivoEmp.Size = New Size(184, 61)
        rdbActivoEmp.TabIndex = 0
        rdbActivoEmp.TabStop = True
        rdbActivoEmp.Text = "Activo"
        rdbActivoEmp.UseVisualStyleBackColor = True
        ' 
        ' txtSueldoEmp
        ' 
        txtSueldoEmp.Location = New Point(184, 182)
        txtSueldoEmp.Margin = New Padding(9)
        txtSueldoEmp.Name = "txtSueldoEmp"
        txtSueldoEmp.Size = New Size(352, 63)
        txtSueldoEmp.TabIndex = 5
        ' 
        ' lblSueldoEmp
        ' 
        lblSueldoEmp.AutoSize = True
        lblSueldoEmp.Location = New Point(17, 202)
        lblSueldoEmp.Margin = New Padding(9, 0, 9, 0)
        lblSueldoEmp.Name = "lblSueldoEmp"
        lblSueldoEmp.Size = New Size(162, 57)
        lblSueldoEmp.TabIndex = 4
        lblSueldoEmp.Text = "Sueldo:"
        ' 
        ' grpDatosEnf
        ' 
        grpDatosEnf.Controls.Add(btnBuscEmp)
        grpDatosEnf.Controls.Add(cbxEstadoCivEmp)
        grpDatosEnf.Controls.Add(lblEstadoCivEmp)
        grpDatosEnf.Controls.Add(mskTelEmp)
        grpDatosEnf.Controls.Add(lblTelefonoEmp)
        grpDatosEnf.Controls.Add(txtCorreoEmp)
        grpDatosEnf.Controls.Add(lblCorreoEmp)
        grpDatosEnf.Controls.Add(txtDirecEmp)
        grpDatosEnf.Controls.Add(lblDirecEmp)
        grpDatosEnf.Controls.Add(grpGeneroEmp)
        grpDatosEnf.Controls.Add(txtEdadEmp)
        grpDatosEnf.Controls.Add(lblEdadEmp)
        grpDatosEnf.Controls.Add(dtpFechaNacEmp)
        grpDatosEnf.Controls.Add(lblFechaNacEmp)
        grpDatosEnf.Controls.Add(txtApeEmp)
        grpDatosEnf.Controls.Add(lblApeEmp)
        grpDatosEnf.Controls.Add(txtNombEmp)
        grpDatosEnf.Controls.Add(lblNombEmp)
        grpDatosEnf.Controls.Add(mskIdentEmp)
        grpDatosEnf.Controls.Add(lblIdentEmp)
        grpDatosEnf.Location = New Point(66, 228)
        grpDatosEnf.Margin = New Padding(9)
        grpDatosEnf.Name = "grpDatosEnf"
        grpDatosEnf.Padding = New Padding(9)
        grpDatosEnf.Size = New Size(1406, 1217)
        grpDatosEnf.TabIndex = 13
        grpDatosEnf.TabStop = False
        grpDatosEnf.Text = "Datos Personales"
        ' 
        ' btnBuscEmp
        ' 
        btnBuscEmp.Location = New Point(1138, 74)
        btnBuscEmp.Margin = New Padding(9)
        btnBuscEmp.Name = "btnBuscEmp"
        btnBuscEmp.Size = New Size(250, 86)
        btnBuscEmp.TabIndex = 18
        btnBuscEmp.Text = "Buscar"
        btnBuscEmp.UseVisualStyleBackColor = True
        ' 
        ' cbxEstadoCivEmp
        ' 
        cbxEstadoCivEmp.FormattingEnabled = True
        cbxEstadoCivEmp.Items.AddRange(New Object() {"Casado", "Soltero", "Viudo"})
        cbxEstadoCivEmp.Location = New Point(290, 1083)
        cbxEstadoCivEmp.Margin = New Padding(9)
        cbxEstadoCivEmp.Name = "cbxEstadoCivEmp"
        cbxEstadoCivEmp.Size = New Size(427, 65)
        cbxEstadoCivEmp.TabIndex = 17
        ' 
        ' lblEstadoCivEmp
        ' 
        lblEstadoCivEmp.AutoSize = True
        lblEstadoCivEmp.Location = New Point(17, 1106)
        lblEstadoCivEmp.Margin = New Padding(9, 0, 9, 0)
        lblEstadoCivEmp.Name = "lblEstadoCivEmp"
        lblEstadoCivEmp.Size = New Size(246, 57)
        lblEstadoCivEmp.TabIndex = 16
        lblEstadoCivEmp.Text = "Estado Civil:"
        ' 
        ' mskTelEmp
        ' 
        mskTelEmp.Location = New Point(227, 986)
        mskTelEmp.Margin = New Padding(9)
        mskTelEmp.Name = "mskTelEmp"
        mskTelEmp.Size = New Size(493, 63)
        mskTelEmp.TabIndex = 15
        ' 
        ' lblTelefonoEmp
        ' 
        lblTelefonoEmp.AutoSize = True
        lblTelefonoEmp.Location = New Point(17, 1006)
        lblTelefonoEmp.Margin = New Padding(9, 0, 9, 0)
        lblTelefonoEmp.Name = "lblTelefonoEmp"
        lblTelefonoEmp.Size = New Size(193, 57)
        lblTelefonoEmp.TabIndex = 14
        lblTelefonoEmp.Text = "Teléfono:"
        ' 
        ' txtCorreoEmp
        ' 
        txtCorreoEmp.Location = New Point(198, 881)
        txtCorreoEmp.Margin = New Padding(9)
        txtCorreoEmp.Name = "txtCorreoEmp"
        txtCorreoEmp.Size = New Size(438, 63)
        txtCorreoEmp.TabIndex = 13
        ' 
        ' lblCorreoEmp
        ' 
        lblCorreoEmp.AutoSize = True
        lblCorreoEmp.Location = New Point(17, 901)
        lblCorreoEmp.Margin = New Padding(9, 0, 9, 0)
        lblCorreoEmp.Name = "lblCorreoEmp"
        lblCorreoEmp.Size = New Size(162, 57)
        lblCorreoEmp.TabIndex = 12
        lblCorreoEmp.Text = "Correo:"
        ' 
        ' txtDirecEmp
        ' 
        txtDirecEmp.Location = New Point(250, 789)
        txtDirecEmp.Margin = New Padding(9)
        txtDirecEmp.Name = "txtDirecEmp"
        txtDirecEmp.Size = New Size(570, 63)
        txtDirecEmp.TabIndex = 11
        ' 
        ' lblDirecEmp
        ' 
        lblDirecEmp.AutoSize = True
        lblDirecEmp.Location = New Point(17, 809)
        lblDirecEmp.Margin = New Padding(9, 0, 9, 0)
        lblDirecEmp.Name = "lblDirecEmp"
        lblDirecEmp.Size = New Size(207, 57)
        lblDirecEmp.TabIndex = 10
        lblDirecEmp.Text = "Dirección:"
        ' 
        ' grpGeneroEmp
        ' 
        grpGeneroEmp.Controls.Add(rdbFemeninoEmp)
        grpGeneroEmp.Controls.Add(rdbMasculinoEmp)
        grpGeneroEmp.Location = New Point(227, 613)
        grpGeneroEmp.Margin = New Padding(9)
        grpGeneroEmp.Name = "grpGeneroEmp"
        grpGeneroEmp.Padding = New Padding(9)
        grpGeneroEmp.Size = New Size(638, 140)
        grpGeneroEmp.TabIndex = 9
        grpGeneroEmp.TabStop = False
        grpGeneroEmp.Text = "Género"
        ' 
        ' rdbFemeninoEmp
        ' 
        rdbFemeninoEmp.AutoSize = True
        rdbFemeninoEmp.Location = New Point(23, 54)
        rdbFemeninoEmp.Margin = New Padding(9)
        rdbFemeninoEmp.Name = "rdbFemeninoEmp"
        rdbFemeninoEmp.Size = New Size(253, 61)
        rdbFemeninoEmp.TabIndex = 10
        rdbFemeninoEmp.TabStop = True
        rdbFemeninoEmp.Text = "Femenino"
        rdbFemeninoEmp.UseVisualStyleBackColor = True
        ' 
        ' rdbMasculinoEmp
        ' 
        rdbMasculinoEmp.AutoSize = True
        rdbMasculinoEmp.Location = New Point(342, 54)
        rdbMasculinoEmp.Margin = New Padding(9)
        rdbMasculinoEmp.Name = "rdbMasculinoEmp"
        rdbMasculinoEmp.Size = New Size(258, 61)
        rdbMasculinoEmp.TabIndex = 10
        rdbMasculinoEmp.TabStop = True
        rdbMasculinoEmp.Text = "Masculino"
        rdbMasculinoEmp.UseVisualStyleBackColor = True
        ' 
        ' txtEdadEmp
        ' 
        txtEdadEmp.Location = New Point(167, 493)
        txtEdadEmp.Margin = New Padding(9)
        txtEdadEmp.Name = "txtEdadEmp"
        txtEdadEmp.Size = New Size(441, 63)
        txtEdadEmp.TabIndex = 2
        ' 
        ' lblEdadEmp
        ' 
        lblEdadEmp.AutoSize = True
        lblEdadEmp.Location = New Point(17, 513)
        lblEdadEmp.Margin = New Padding(9, 0, 9, 0)
        lblEdadEmp.Name = "lblEdadEmp"
        lblEdadEmp.Size = New Size(126, 57)
        lblEdadEmp.TabIndex = 8
        lblEdadEmp.Text = "Edad:"
        ' 
        ' dtpFechaNacEmp
        ' 
        dtpFechaNacEmp.Location = New Point(472, 393)
        dtpFechaNacEmp.Margin = New Padding(9)
        dtpFechaNacEmp.Name = "dtpFechaNacEmp"
        dtpFechaNacEmp.Size = New Size(711, 63)
        dtpFechaNacEmp.TabIndex = 7
        ' 
        ' lblFechaNacEmp
        ' 
        lblFechaNacEmp.AutoSize = True
        lblFechaNacEmp.Location = New Point(17, 413)
        lblFechaNacEmp.Margin = New Padding(9, 0, 9, 0)
        lblFechaNacEmp.Name = "lblFechaNacEmp"
        lblFechaNacEmp.Size = New Size(424, 57)
        lblFechaNacEmp.TabIndex = 6
        lblFechaNacEmp.Text = "Fecha de Nacimiento:"
        ' 
        ' txtApeEmp
        ' 
        txtApeEmp.Location = New Point(227, 285)
        txtApeEmp.Margin = New Padding(9)
        txtApeEmp.Name = "txtApeEmp"
        txtApeEmp.Size = New Size(596, 63)
        txtApeEmp.TabIndex = 5
        ' 
        ' lblApeEmp
        ' 
        lblApeEmp.AutoSize = True
        lblApeEmp.Location = New Point(17, 305)
        lblApeEmp.Margin = New Padding(9, 0, 9, 0)
        lblApeEmp.Name = "lblApeEmp"
        lblApeEmp.Size = New Size(188, 57)
        lblApeEmp.TabIndex = 4
        lblApeEmp.Text = "Apellido:"
        ' 
        ' txtNombEmp
        ' 
        txtNombEmp.Location = New Point(227, 182)
        txtNombEmp.Margin = New Padding(9)
        txtNombEmp.Name = "txtNombEmp"
        txtNombEmp.Size = New Size(570, 63)
        txtNombEmp.TabIndex = 2
        ' 
        ' lblNombEmp
        ' 
        lblNombEmp.AutoSize = True
        lblNombEmp.Location = New Point(17, 202)
        lblNombEmp.Margin = New Padding(9, 0, 9, 0)
        lblNombEmp.Name = "lblNombEmp"
        lblNombEmp.Size = New Size(188, 57)
        lblNombEmp.TabIndex = 3
        lblNombEmp.Text = "Nombre:"
        ' 
        ' mskIdentEmp
        ' 
        mskIdentEmp.Location = New Point(472, 83)
        mskIdentEmp.Margin = New Padding(9)
        mskIdentEmp.Name = "mskIdentEmp"
        mskIdentEmp.Size = New Size(642, 63)
        mskIdentEmp.TabIndex = 2
        ' 
        ' lblIdentEmp
        ' 
        lblIdentEmp.AutoSize = True
        lblIdentEmp.Location = New Point(17, 103)
        lblIdentEmp.Margin = New Padding(9, 0, 9, 0)
        lblIdentEmp.Name = "lblIdentEmp"
        lblIdentEmp.Size = New Size(435, 57)
        lblIdentEmp.TabIndex = 2
        lblIdentEmp.Text = "Número de Identidad:"
        ' 
        ' lblNombFormEmp
        ' 
        lblNombFormEmp.AutoSize = True
        lblNombFormEmp.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblNombFormEmp.Location = New Point(1182, 26)
        lblNombFormEmp.Margin = New Padding(9, 0, 9, 0)
        lblNombFormEmp.Name = "lblNombFormEmp"
        lblNombFormEmp.Size = New Size(874, 112)
        lblNombFormEmp.TabIndex = 12
        lblNombFormEmp.Text = "Formulario Empleados"
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(23F, 57F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(3079, 1707)
        Controls.Add(btnElimEmp)
        Controls.Add(btnModificarEmp)
        Controls.Add(btnAgregarEmp)
        Controls.Add(grpDatosProfEmp)
        Controls.Add(grpDatosEnf)
        Controls.Add(lblNombFormEmp)
        Margin = New Padding(9)
        Name = "Form5"
        Text = "Form5"
        grpDatosProfEmp.ResumeLayout(False)
        grpDatosProfEmp.PerformLayout()
        grpEstadoEmp.ResumeLayout(False)
        grpEstadoEmp.PerformLayout()
        grpDatosEnf.ResumeLayout(False)
        grpDatosEnf.PerformLayout()
        grpGeneroEmp.ResumeLayout(False)
        grpGeneroEmp.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnElimEmp As Button
    Friend WithEvents btnModificarEmp As Button
    Friend WithEvents btnAgregarEmp As Button
    Friend WithEvents grpDatosProfEmp As GroupBox
    Friend WithEvents grpEstadoEmp As GroupBox
    Friend WithEvents rdbInactivoEmp As RadioButton
    Friend WithEvents rdbActivoEmp As RadioButton
    Friend WithEvents txtSueldoEmp As TextBox
    Friend WithEvents lblSueldoEmp As Label
    Friend WithEvents grpDatosEnf As GroupBox
    Friend WithEvents btnBuscEmp As Button
    Friend WithEvents cbxEstadoCivEmp As ComboBox
    Friend WithEvents lblEstadoCivEmp As Label
    Friend WithEvents mskTelEmp As MaskedTextBox
    Friend WithEvents lblTelefonoEmp As Label
    Friend WithEvents txtCorreoEmp As TextBox
    Friend WithEvents lblCorreoEmp As Label
    Friend WithEvents txtDirecEmp As TextBox
    Friend WithEvents lblDirecEmp As Label
    Friend WithEvents grpGeneroEmp As GroupBox
    Friend WithEvents rdbFemeninoEmp As RadioButton
    Friend WithEvents rdbMasculinoEmp As RadioButton
    Friend WithEvents txtEdadEmp As TextBox
    Friend WithEvents lblEdadEmp As Label
    Friend WithEvents dtpFechaNacEmp As DateTimePicker
    Friend WithEvents lblFechaNacEmp As Label
    Friend WithEvents txtApeEmp As TextBox
    Friend WithEvents lblApeEmp As Label
    Friend WithEvents txtNombEmp As TextBox
    Friend WithEvents lblNombEmp As Label
    Friend WithEvents mskIdentEmp As MaskedTextBox
    Friend WithEvents lblIdentEmp As Label
    Friend WithEvents lblNombFormEmp As Label
    Friend WithEvents cbxCargoEmp As ComboBox
    Friend WithEvents lblCargoEmp As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
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
        lblFormSalas = New Label()
        grpInfoSala = New GroupBox()
        lblIdSala = New Label()
        txtIdSala = New TextBox()
        lblNombSala = New Label()
        txtNombSala = New TextBox()
        lblPisoSala = New Label()
        txtPisoSala = New TextBox()
        lblCapacidadSala = New Label()
        txtCapacidadSala = New TextBox()
        lblCatSala = New Label()
        cbxTipoSala = New ComboBox()
        lblFechaMantSala = New Label()
        grpInfoSala.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblFormSalas
        ' 
        lblFormSalas.AutoSize = True
        lblFormSalas.Font = New Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFormSalas.Location = New Point(313, 9)
        lblFormSalas.Name = "lblFormSalas"
        lblFormSalas.Size = New Size(277, 41)
        lblFormSalas.TabIndex = 0
        lblFormSalas.Text = "Formulario de Salas"
        ' 
        ' grpInfoSala
        ' 
        grpInfoSala.Controls.Add(lblFechaMantSala)
        grpInfoSala.Controls.Add(cbxTipoSala)
        grpInfoSala.Controls.Add(lblCatSala)
        grpInfoSala.Controls.Add(txtCapacidadSala)
        grpInfoSala.Controls.Add(lblCapacidadSala)
        grpInfoSala.Controls.Add(txtPisoSala)
        grpInfoSala.Controls.Add(lblPisoSala)
        grpInfoSala.Controls.Add(txtNombSala)
        grpInfoSala.Controls.Add(lblNombSala)
        grpInfoSala.Controls.Add(txtIdSala)
        grpInfoSala.Controls.Add(lblIdSala)
        grpInfoSala.Location = New Point(34, 73)
        grpInfoSala.Name = "grpInfoSala"
        grpInfoSala.Size = New Size(510, 265)
        grpInfoSala.TabIndex = 1
        grpInfoSala.TabStop = False
        grpInfoSala.Text = "Informacion de Sala"
        ' 
        ' lblIdSala
        ' 
        lblIdSala.AutoSize = True
        lblIdSala.Location = New Point(6, 32)
        lblIdSala.Name = "lblIdSala"
        lblIdSala.Size = New Size(59, 20)
        lblIdSala.TabIndex = 2
        lblIdSala.Text = "ID Sala:"
        ' 
        ' txtIdSala
        ' 
        txtIdSala.Location = New Point(71, 25)
        txtIdSala.Name = "txtIdSala"
        txtIdSala.Size = New Size(167, 27)
        txtIdSala.TabIndex = 2
        ' 
        ' lblNombSala
        ' 
        lblNombSala.AutoSize = True
        lblNombSala.Location = New Point(6, 68)
        lblNombSala.Name = "lblNombSala"
        lblNombSala.Size = New Size(136, 20)
        lblNombSala.TabIndex = 3
        lblNombSala.Text = "Nombre de la Sala:"
        ' 
        ' txtNombSala
        ' 
        txtNombSala.Location = New Point(148, 61)
        txtNombSala.Name = "txtNombSala"
        txtNombSala.Size = New Size(213, 27)
        txtNombSala.TabIndex = 4
        ' 
        ' lblPisoSala
        ' 
        lblPisoSala.AutoSize = True
        lblPisoSala.Location = New Point(6, 100)
        lblPisoSala.Name = "lblPisoSala"
        lblPisoSala.Size = New Size(39, 20)
        lblPisoSala.TabIndex = 5
        lblPisoSala.Text = "Piso:"
        ' 
        ' txtPisoSala
        ' 
        txtPisoSala.Location = New Point(51, 93)
        txtPisoSala.Name = "txtPisoSala"
        txtPisoSala.Size = New Size(136, 27)
        txtPisoSala.TabIndex = 2
        ' 
        ' lblCapacidadSala
        ' 
        lblCapacidadSala.AutoSize = True
        lblCapacidadSala.Location = New Point(6, 134)
        lblCapacidadSala.Name = "lblCapacidadSala"
        lblCapacidadSala.Size = New Size(83, 20)
        lblCapacidadSala.TabIndex = 2
        lblCapacidadSala.Text = "Capacidad:"
        ' 
        ' txtCapacidadSala
        ' 
        txtCapacidadSala.Location = New Point(95, 127)
        txtCapacidadSala.Name = "txtCapacidadSala"
        txtCapacidadSala.Size = New Size(125, 27)
        txtCapacidadSala.TabIndex = 2
        ' 
        ' lblCatSala
        ' 
        lblCatSala.AutoSize = True
        lblCatSala.Location = New Point(6, 165)
        lblCatSala.Name = "lblCatSala"
        lblCatSala.Size = New Size(74, 20)
        lblCatSala.TabIndex = 2
        lblCatSala.Text = "Tipo Sala:"
        ' 
        ' cbxTipoSala
        ' 
        cbxTipoSala.FormattingEnabled = True
        cbxTipoSala.Location = New Point(86, 157)
        cbxTipoSala.Name = "cbxTipoSala"
        cbxTipoSala.Size = New Size(151, 28)
        cbxTipoSala.TabIndex = 2
        ' 
        ' lblFechaMantSala
        ' 
        lblFechaMantSala.AutoSize = True
        lblFechaMantSala.Location = New Point(6, 194)
        lblFechaMantSala.Name = "lblFechaMantSala"
        lblFechaMantSala.Size = New Size(223, 20)
        lblFechaMantSala.TabIndex = 2
        lblFechaMantSala.Text = "Fecha de último mantenimiento:"
        ' 
        ' Form10
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(929, 547)
        Controls.Add(grpInfoSala)
        Controls.Add(lblFormSalas)
        Name = "Form10"
        Text = "Form10"
        grpInfoSala.ResumeLayout(False)
        grpInfoSala.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFormSalas As Label
    Friend WithEvents grpInfoSala As GroupBox
    Friend WithEvents lblNombSala As Label
    Friend WithEvents txtIdSala As TextBox
    Friend WithEvents lblIdSala As Label
    Friend WithEvents lblPisoSala As Label
    Friend WithEvents txtNombSala As TextBox
    Friend WithEvents lblFechaMantSala As Label
    Friend WithEvents cbxTipoSala As ComboBox
    Friend WithEvents lblCatSala As Label
    Friend WithEvents txtCapacidadSala As TextBox
    Friend WithEvents lblCapacidadSala As Label
    Friend WithEvents txtPisoSala As TextBox
End Class

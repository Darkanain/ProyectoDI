<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RegistroEmpleado
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroEmpleado))
        Me.ControlRegistro = New RegistroRest.ControlRegistro()
        Me.btnCanc = New System.Windows.Forms.Button()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ControlRegistro
        '
        resources.ApplyResources(Me.ControlRegistro, "ControlRegistro")
        Me.ControlRegistro.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.ControlRegistro.Name = "ControlRegistro"
        '
        'btnCanc
        '
        resources.ApplyResources(Me.btnCanc, "btnCanc")
        Me.btnCanc.Name = "btnCanc"
        Me.btnCanc.UseVisualStyleBackColor = True
        '
        'btnConf
        '
        resources.ApplyResources(Me.btnConf, "btnConf")
        Me.btnConf.Name = "btnConf"
        Me.btnConf.UseVisualStyleBackColor = True
        '
        'RegistroEmpleado
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.btnCanc)
        Me.Controls.Add(Me.ControlRegistro)
        Me.KeyPreview = True
        Me.Name = "RegistroEmpleado"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ControlRegistro As RegistroRest.ControlRegistro
    Friend WithEvents btnCanc As Button
    Friend WithEvents btnConf As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fPrincipal))
        Me.menuSup = New System.Windows.Forms.MenuStrip()
        Me.selectIdioma = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectEsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.selectEng = New System.Windows.Forms.ToolStripMenuItem()
        Me.menuAyuda = New System.Windows.Forms.ToolStripMenuItem()
        Me.ayudaOnline = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNomRest = New System.Windows.Forms.Label()
        Me.btnRLol = New System.Windows.Forms.Button()
        Me.btnRNormal = New System.Windows.Forms.Button()
        Me.pbFondo = New System.Windows.Forms.PictureBox()
        Me.menuSup.SuspendLayout()
        CType(Me.pbFondo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'menuSup
        '
        resources.ApplyResources(Me.menuSup, "menuSup")
        Me.menuSup.BackColor = System.Drawing.SystemColors.Window
        Me.menuSup.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.selectIdioma, Me.menuAyuda})
        Me.menuSup.Name = "menuSup"
        '
        'selectIdioma
        '
        resources.ApplyResources(Me.selectIdioma, "selectIdioma")
        Me.selectIdioma.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.selectEsp, Me.selectEng})
        Me.selectIdioma.Name = "selectIdioma"
        '
        'selectEsp
        '
        resources.ApplyResources(Me.selectEsp, "selectEsp")
        Me.selectEsp.Name = "selectEsp"
        '
        'selectEng
        '
        resources.ApplyResources(Me.selectEng, "selectEng")
        Me.selectEng.Name = "selectEng"
        '
        'menuAyuda
        '
        resources.ApplyResources(Me.menuAyuda, "menuAyuda")
        Me.menuAyuda.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ayudaOnline})
        Me.menuAyuda.Name = "menuAyuda"
        '
        'ayudaOnline
        '
        resources.ApplyResources(Me.ayudaOnline, "ayudaOnline")
        Me.ayudaOnline.Name = "ayudaOnline"
        '
        'lblNomRest
        '
        resources.ApplyResources(Me.lblNomRest, "lblNomRest")
        Me.lblNomRest.BackColor = System.Drawing.Color.Black
        Me.lblNomRest.ForeColor = System.Drawing.Color.Gold
        Me.lblNomRest.Name = "lblNomRest"
        '
        'btnRLol
        '
        resources.ApplyResources(Me.btnRLol, "btnRLol")
        Me.btnRLol.Name = "btnRLol"
        Me.btnRLol.UseVisualStyleBackColor = True
        '
        'btnRNormal
        '
        resources.ApplyResources(Me.btnRNormal, "btnRNormal")
        Me.btnRNormal.Name = "btnRNormal"
        Me.btnRNormal.UseVisualStyleBackColor = True
        '
        'pbFondo
        '
        resources.ApplyResources(Me.pbFondo, "pbFondo")
        Me.pbFondo.Image = Global.ProyectoDI.My.Resources.Resources.Fondo1
        Me.pbFondo.Name = "pbFondo"
        Me.pbFondo.TabStop = False
        '
        'fPrincipal
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblNomRest)
        Me.Controls.Add(Me.btnRLol)
        Me.Controls.Add(Me.btnRNormal)
        Me.Controls.Add(Me.pbFondo)
        Me.Controls.Add(Me.menuSup)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.menuSup
        Me.Name = "fPrincipal"
        Me.menuSup.ResumeLayout(False)
        Me.menuSup.PerformLayout()
        CType(Me.pbFondo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menuSup As MenuStrip
    Friend WithEvents selectIdioma As ToolStripMenuItem
    Friend WithEvents selectEsp As ToolStripMenuItem
    Friend WithEvents selectEng As ToolStripMenuItem
    Friend WithEvents menuAyuda As ToolStripMenuItem
    Friend WithEvents ayudaOnline As ToolStripMenuItem
    Friend WithEvents lblNomRest As Label
    Friend WithEvents btnRLol As Button
    Friend WithEvents btnRNormal As Button
    Friend WithEvents pbFondo As PictureBox
End Class

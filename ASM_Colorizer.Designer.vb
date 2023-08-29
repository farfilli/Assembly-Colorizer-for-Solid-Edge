<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASM_Colorizer
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ASM_Colorizer))
        Me.BT_Colorize = New System.Windows.Forms.Button()
        Me.SkipTXT = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_SubOccurrences = New System.Windows.Forms.CheckBox()
        Me.CB_SameColor = New System.Windows.Forms.CheckBox()
        Me.PB = New System.Windows.Forms.ProgressBar()
        Me.CheckBackground = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'BT_Colorize
        '
        Me.BT_Colorize.Location = New System.Drawing.Point(217, 48)
        Me.BT_Colorize.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_Colorize.Name = "BT_Colorize"
        Me.BT_Colorize.Size = New System.Drawing.Size(121, 60)
        Me.BT_Colorize.TabIndex = 0
        Me.BT_Colorize.Text = "Colorize"
        Me.BT_Colorize.UseVisualStyleBackColor = True
        '
        'SkipTXT
        '
        Me.SkipTXT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SkipTXT.Location = New System.Drawing.Point(9, 24)
        Me.SkipTXT.Margin = New System.Windows.Forms.Padding(2)
        Me.SkipTXT.Name = "SkipTXT"
        Me.SkipTXT.Size = New System.Drawing.Size(329, 20)
        Me.SkipTXT.TabIndex = 1
        Me.SkipTXT.Text = "glass,clear"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Skip styles that contains this text (comma separated)"
        '
        'CB_SubOccurrences
        '
        Me.CB_SubOccurrences.AutoSize = True
        Me.CB_SubOccurrences.Checked = True
        Me.CB_SubOccurrences.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_SubOccurrences.Location = New System.Drawing.Point(9, 48)
        Me.CB_SubOccurrences.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_SubOccurrences.Name = "CB_SubOccurrences"
        Me.CB_SubOccurrences.Size = New System.Drawing.Size(174, 17)
        Me.CB_SubOccurrences.TabIndex = 3
        Me.CB_SubOccurrences.Text = "Single FaceStyle SubAssembly "
        Me.CB_SubOccurrences.UseVisualStyleBackColor = True
        '
        'CB_SameColor
        '
        Me.CB_SameColor.AutoSize = True
        Me.CB_SameColor.Checked = True
        Me.CB_SameColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_SameColor.Location = New System.Drawing.Point(9, 69)
        Me.CB_SameColor.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_SameColor.Name = "CB_SameColor"
        Me.CB_SameColor.Size = New System.Drawing.Size(147, 17)
        Me.CB_SameColor.TabIndex = 3
        Me.CB_SameColor.Text = "Same file same FaceStyle"
        Me.CB_SameColor.UseVisualStyleBackColor = True
        '
        'PB
        '
        Me.PB.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB.Location = New System.Drawing.Point(0, 111)
        Me.PB.Margin = New System.Windows.Forms.Padding(0)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(346, 22)
        Me.PB.TabIndex = 4
        '
        'CheckBackground
        '
        Me.CheckBackground.AutoSize = True
        Me.CheckBackground.Location = New System.Drawing.Point(9, 91)
        Me.CheckBackground.Name = "CheckBackground"
        Me.CheckBackground.Size = New System.Drawing.Size(193, 17)
        Me.CheckBackground.TabIndex = 5
        Me.CheckBackground.Text = "Fast mode (Process in background)"
        Me.CheckBackground.UseVisualStyleBackColor = True
        '
        'ASM_Colorizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 133)
        Me.Controls.Add(Me.CheckBackground)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.CB_SameColor)
        Me.Controls.Add(Me.CB_SubOccurrences)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SkipTXT)
        Me.Controls.Add(Me.BT_Colorize)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "ASM_Colorizer"
        Me.Text = "Assembly Colorizer v0.1"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_Colorize As Button
    Friend WithEvents SkipTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_SubOccurrences As CheckBox
    Friend WithEvents CB_SameColor As CheckBox
    Friend WithEvents PB As ProgressBar
    Friend WithEvents CheckBackground As CheckBox
End Class

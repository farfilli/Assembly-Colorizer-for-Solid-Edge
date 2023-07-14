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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.PB = New System.Windows.Forms.ToolStripProgressBar()
        Me.CB_SameColor = New System.Windows.Forms.CheckBox()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BT_Colorize
        '
        Me.BT_Colorize.Location = New System.Drawing.Point(217, 46)
        Me.BT_Colorize.Margin = New System.Windows.Forms.Padding(2)
        Me.BT_Colorize.Name = "BT_Colorize"
        Me.BT_Colorize.Size = New System.Drawing.Size(121, 40)
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
        Me.CB_SubOccurrences.Size = New System.Drawing.Size(150, 17)
        Me.CB_SubOccurrences.TabIndex = 3
        Me.CB_SubOccurrences.Text = "Single color SubAssembly "
        Me.CB_SubOccurrences.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.PB})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 92)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(346, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(0, 17)
        '
        'PB
        '
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(75, 16)
        '
        'CB_SameColor
        '
        Me.CB_SameColor.AutoSize = True
        Me.CB_SameColor.Checked = True
        Me.CB_SameColor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CB_SameColor.Location = New System.Drawing.Point(9, 69)
        Me.CB_SameColor.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_SameColor.Name = "CB_SameColor"
        Me.CB_SameColor.Size = New System.Drawing.Size(164, 17)
        Me.CB_SameColor.TabIndex = 3
        Me.CB_SameColor.Text = "Same occurrence same color"
        Me.CB_SameColor.UseVisualStyleBackColor = True
        '
        'ASM_Colorizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(346, 114)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.CB_SameColor)
        Me.Controls.Add(Me.CB_SubOccurrences)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SkipTXT)
        Me.Controls.Add(Me.BT_Colorize)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "ASM_Colorizer"
        Me.Text = "Assembly Colorizer"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_Colorize As Button
    Friend WithEvents SkipTXT As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB_SubOccurrences As CheckBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents PB As ToolStripProgressBar
    Friend WithEvents CB_SameColor As CheckBox
End Class

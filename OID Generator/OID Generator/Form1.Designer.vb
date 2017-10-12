<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.txtRootOID = New System.Windows.Forms.TextBox()
        Me.lblRoot = New System.Windows.Forms.Label()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(229, 129)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(114, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate OID"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'txtRootOID
        '
        Me.txtRootOID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRootOID.Location = New System.Drawing.Point(12, 103)
        Me.txtRootOID.Name = "txtRootOID"
        Me.txtRootOID.ReadOnly = True
        Me.txtRootOID.Size = New System.Drawing.Size(520, 13)
        Me.txtRootOID.TabIndex = 1
        '
        'lblRoot
        '
        Me.lblRoot.AutoSize = True
        Me.lblRoot.Location = New System.Drawing.Point(13, 84)
        Me.lblRoot.Name = "lblRoot"
        Me.lblRoot.Size = New System.Drawing.Size(85, 13)
        Me.lblRoot.TabIndex = 2
        Me.lblRoot.Text = "Your root OID is:"
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(13, 13)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(542, 52)
        Me.lblDescription.TabIndex = 3
        Me.lblDescription.Text = resources.GetString("lblDescription.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 179)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.lblRoot)
        Me.Controls.Add(Me.txtRootOID)
        Me.Controls.Add(Me.btnGenerate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OID Generator for Active Directory Custom Attributes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents txtRootOID As System.Windows.Forms.TextBox
    Friend WithEvents lblRoot As System.Windows.Forms.Label
    Friend WithEvents lblDescription As System.Windows.Forms.Label

End Class

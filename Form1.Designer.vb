<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StateAbbreviations
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
        Me.btnVirgina = New System.Windows.Forms.Button()
        Me.btnNorthCarolina = New System.Windows.Forms.Button()
        Me.btnSouthCarolina = New System.Windows.Forms.Button()
        Me.btnGeorgia = New System.Windows.Forms.Button()
        Me.btnAlabama = New System.Windows.Forms.Button()
        Me.btnFLorida = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVirgina
        '
        Me.btnVirgina.Location = New System.Drawing.Point(32, 282)
        Me.btnVirgina.Name = "btnVirgina"
        Me.btnVirgina.Size = New System.Drawing.Size(75, 23)
        Me.btnVirgina.TabIndex = 0
        Me.btnVirgina.Text = "Virginia"
        Me.btnVirgina.UseVisualStyleBackColor = True
        '
        'btnNorthCarolina
        '
        Me.btnNorthCarolina.Location = New System.Drawing.Point(125, 282)
        Me.btnNorthCarolina.Name = "btnNorthCarolina"
        Me.btnNorthCarolina.Size = New System.Drawing.Size(78, 34)
        Me.btnNorthCarolina.TabIndex = 1
        Me.btnNorthCarolina.Text = "North Carolina"
        Me.btnNorthCarolina.UseVisualStyleBackColor = True
        '
        'btnSouthCarolina
        '
        Me.btnSouthCarolina.Location = New System.Drawing.Point(222, 282)
        Me.btnSouthCarolina.Name = "btnSouthCarolina"
        Me.btnSouthCarolina.Size = New System.Drawing.Size(75, 34)
        Me.btnSouthCarolina.TabIndex = 2
        Me.btnSouthCarolina.Text = "South Carolina"
        Me.btnSouthCarolina.UseVisualStyleBackColor = True
        '
        'btnGeorgia
        '
        Me.btnGeorgia.Location = New System.Drawing.Point(317, 282)
        Me.btnGeorgia.Name = "btnGeorgia"
        Me.btnGeorgia.Size = New System.Drawing.Size(75, 23)
        Me.btnGeorgia.TabIndex = 3
        Me.btnGeorgia.Text = "Georgia"
        Me.btnGeorgia.UseVisualStyleBackColor = True
        '
        'btnAlabama
        '
        Me.btnAlabama.Location = New System.Drawing.Point(413, 282)
        Me.btnAlabama.Name = "btnAlabama"
        Me.btnAlabama.Size = New System.Drawing.Size(75, 23)
        Me.btnAlabama.TabIndex = 4
        Me.btnAlabama.Text = "Alabama"
        Me.btnAlabama.UseVisualStyleBackColor = True
        '
        'btnFLorida
        '
        Me.btnFLorida.Location = New System.Drawing.Point(520, 282)
        Me.btnFLorida.Name = "btnFLorida"
        Me.btnFLorida.Size = New System.Drawing.Size(75, 23)
        Me.btnFLorida.TabIndex = 5
        Me.btnFLorida.Text = "Florida"
        Me.btnFLorida.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(317, 364)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblAnswer
        '
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.Location = New System.Drawing.Point(317, 128)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(75, 33)
        Me.lblAnswer.TabIndex = 7
        '
        'StateAbbreviations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 418)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFLorida)
        Me.Controls.Add(Me.btnAlabama)
        Me.Controls.Add(Me.btnGeorgia)
        Me.Controls.Add(Me.btnSouthCarolina)
        Me.Controls.Add(Me.btnNorthCarolina)
        Me.Controls.Add(Me.btnVirgina)
        Me.Name = "StateAbbreviations"
        Me.Text = "State Abbreviations"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnVirgina As Button
    Friend WithEvents btnNorthCarolina As Button
    Friend WithEvents btnSouthCarolina As Button
    Friend WithEvents btnGeorgia As Button
    Friend WithEvents btnAlabama As Button
    Friend WithEvents btnFLorida As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblAnswer As Label
End Class

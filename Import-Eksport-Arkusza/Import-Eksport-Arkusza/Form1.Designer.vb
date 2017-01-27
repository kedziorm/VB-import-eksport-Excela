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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWczytaj = New System.Windows.Forms.Button()
        Me.btnKoniec = New System.Windows.Forms.Button()
        Me.lblDiagnostyka = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "Arkusz Excel|*.xlsx|Stary arkusz Excel|*.xls"
        Me.OpenFileDialog1.Title = "Proszę wskazać arkusz"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Arkusz Excel|*.xlsx|Stary arkusz Excel|*.xls"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(278, 53)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Program tworzy skoroszyt zawierający statystyki opisowe danych zawartych w innym " &
    "skoroszycie"
        Me.Label1.UseMnemonic = False
        '
        'btnWczytaj
        '
        Me.btnWczytaj.Location = New System.Drawing.Point(17, 302)
        Me.btnWczytaj.Name = "btnWczytaj"
        Me.btnWczytaj.Size = New System.Drawing.Size(134, 23)
        Me.btnWczytaj.TabIndex = 1
        Me.btnWczytaj.Text = "Wczytaj"
        Me.btnWczytaj.UseVisualStyleBackColor = True
        '
        'btnKoniec
        '
        Me.btnKoniec.Location = New System.Drawing.Point(157, 302)
        Me.btnKoniec.Name = "btnKoniec"
        Me.btnKoniec.Size = New System.Drawing.Size(134, 23)
        Me.btnKoniec.TabIndex = 2
        Me.btnKoniec.Text = "Zakończ"
        Me.btnKoniec.UseVisualStyleBackColor = True
        '
        'lblDiagnostyka
        '
        Me.lblDiagnostyka.Location = New System.Drawing.Point(17, 66)
        Me.lblDiagnostyka.Name = "lblDiagnostyka"
        Me.lblDiagnostyka.Size = New System.Drawing.Size(274, 215)
        Me.lblDiagnostyka.TabIndex = 3
        Me.lblDiagnostyka.Text = "Tu pojawią się informacje diagnostyczne"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(309, 340)
        Me.Controls.Add(Me.lblDiagnostyka)
        Me.Controls.Add(Me.btnKoniec)
        Me.Controls.Add(Me.btnWczytaj)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Import eksport arkusza"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents btnWczytaj As Button
    Friend WithEvents btnKoniec As Button
    Friend WithEvents lblDiagnostyka As Label
End Class

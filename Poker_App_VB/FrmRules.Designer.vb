<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmRules
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
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Pair", "Bet * 1"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Two Pairs", "Bet * 3"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Three of a Kind", "Bet * 5"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Straight", "Bet * 10"}, -1)
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Flush", "Bet * 15"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Full House", "Bet * 20"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Four of a Kind", "Bet * 25"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Straight Flush", "Bet * 50"}, -1)
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"Royal Flush", "Bet * 100"}, -1)
        Me.lstRules = New System.Windows.Forms.ListView()
        Me.HandCollumn = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Payout = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lstRules
        '
        Me.lstRules.BackColor = System.Drawing.Color.Green
        Me.lstRules.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lstRules.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.HandCollumn, Me.Payout})
        Me.lstRules.ForeColor = System.Drawing.Color.Gold
        Me.lstRules.GridLines = True
        Me.lstRules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lstRules.HideSelection = False
        Me.lstRules.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4, ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8, ListViewItem9})
        Me.lstRules.Location = New System.Drawing.Point(0, 1)
        Me.lstRules.Name = "lstRules"
        Me.lstRules.Scrollable = False
        Me.lstRules.Size = New System.Drawing.Size(691, 239)
        Me.lstRules.TabIndex = 0
        Me.lstRules.UseCompatibleStateImageBehavior = False
        Me.lstRules.View = System.Windows.Forms.View.Details
        '
        'HandCollumn
        '
        Me.HandCollumn.Text = "Hand"
        Me.HandCollumn.Width = 156
        '
        'Payout
        '
        Me.Payout.Text = "Payout"
        Me.Payout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.Payout.Width = 535
        '
        'FrmRules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(688, 236)
        Me.Controls.Add(Me.lstRules)
        Me.Font = New System.Drawing.Font("Arial Rounded MT Bold", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Yellow
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "FrmRules"
        Me.ShowIcon = False
        Me.Text = "Rules"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lstRules As ListView
    Friend WithEvents HandCollumn As ColumnHeader
    Friend WithEvents Payout As ColumnHeader
End Class

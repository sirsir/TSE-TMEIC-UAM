﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class frmResultInput
    Inherits MESPdHandy.frmBase

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmResultInput))
        Me.lblProcess = New MESPdControl.CfLabel
        Me.lblProductPlan = New MESPdControl.CfLabel
        Me.lblProductName = New MESPdControl.CfLabel
        Me.lblProcessName = New MESPdControl.CfLabel
        Me.lblProductPlanNo = New MESPdControl.CfLabel
        Me.lblCount = New MESPdControl.CfLabel
        Me.lblState = New MESPdControl.CfLabel
        Me.lblStateName = New MESPdControl.CfLabel
        Me.btnStart = New MESPdControl.CfButton
        Me.btnFinish = New MESPdControl.CfButton
        Me.btnProduct = New MESPdControl.CfButton
        Me.lblProduct = New MESPdControl.CfLabel
        Me.SuspendLayout()
        '
        'btnF1
        '
        resources.ApplyResources(Me.btnF1, "btnF1")
        '
        'btnF2
        '
        resources.ApplyResources(Me.btnF2, "btnF2")
        '
        'btnF3
        '
        resources.ApplyResources(Me.btnF3, "btnF3")
        '
        'btnF4
        '
        resources.ApplyResources(Me.btnF4, "btnF4")
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        '
        'btnClose
        '
        resources.ApplyResources(Me.btnClose, "btnClose")
        '
        'btnF5
        '
        resources.ApplyResources(Me.btnF5, "btnF5")
        '
        'lblProcess
        '
        resources.ApplyResources(Me.lblProcess, "lblProcess")
        Me.lblProcess.Name = "lblProcess"
        Me.lblProcess.UseMnemonic = False
        '
        'lblProductPlan
        '
        resources.ApplyResources(Me.lblProductPlan, "lblProductPlan")
        Me.lblProductPlan.Name = "lblProductPlan"
        Me.lblProductPlan.UseMnemonic = False
        '
        'lblProductName
        '
        Me.lblProductName.BackColor = System.Drawing.Color.Wheat
        resources.ApplyResources(Me.lblProductName, "lblProductName")
        Me.lblProductName.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.UseMnemonic = False
        '
        'lblProcessName
        '
        Me.lblProcessName.BackColor = System.Drawing.Color.Wheat
        resources.ApplyResources(Me.lblProcessName, "lblProcessName")
        Me.lblProcessName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProcessName.Name = "lblProcessName"
        Me.lblProcessName.UseMnemonic = False
        '
        'lblProductPlanNo
        '
        Me.lblProductPlanNo.BackColor = System.Drawing.Color.Wheat
        resources.ApplyResources(Me.lblProductPlanNo, "lblProductPlanNo")
        Me.lblProductPlanNo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblProductPlanNo.Name = "lblProductPlanNo"
        Me.lblProductPlanNo.UseMnemonic = False
        '
        'lblCount
        '
        resources.ApplyResources(Me.lblCount, "lblCount")
        Me.lblCount.Name = "lblCount"
        Me.lblCount.UseMnemonic = False
        '
        'lblState
        '
        resources.ApplyResources(Me.lblState, "lblState")
        Me.lblState.Name = "lblState"
        Me.lblState.UseMnemonic = False
        '
        'lblStateName
        '
        Me.lblStateName.BackColor = System.Drawing.Color.Wheat
        resources.ApplyResources(Me.lblStateName, "lblStateName")
        Me.lblStateName.ForeColor = System.Drawing.Color.Green
        Me.lblStateName.Name = "lblStateName"
        Me.lblStateName.UseMnemonic = False
        '
        'btnStart
        '
        Me.btnStart.Highlight = True
        resources.ApplyResources(Me.btnStart, "btnStart")
        Me.btnStart.Name = "btnStart"
        Me.btnStart.UseMnemonic = False
        '
        'btnFinish
        '
        Me.btnFinish.Highlight = True
        resources.ApplyResources(Me.btnFinish, "btnFinish")
        Me.btnFinish.Name = "btnFinish"
        Me.btnFinish.UseMnemonic = False
        '
        'btnProduct
        '
        Me.btnProduct.Highlight = True
        resources.ApplyResources(Me.btnProduct, "btnProduct")
        Me.btnProduct.Name = "btnProduct"
        Me.btnProduct.UseMnemonic = False
        '
        'lblProduct
        '
        resources.ApplyResources(Me.lblProduct, "lblProduct")
        Me.lblProduct.Name = "lblProduct"
        Me.lblProduct.UseMnemonic = False
        '
        'frmResultInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        resources.ApplyResources(Me, "$this")
        Me.Controls.Add(Me.lblProduct)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.lblProductPlanNo)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.lblProcess)
        Me.Controls.Add(Me.lblProcessName)
        Me.Controls.Add(Me.lblProductPlan)
        Me.Controls.Add(Me.btnProduct)
        Me.Controls.Add(Me.btnFinish)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblStateName)
        Me.Controls.Add(Me.lblState)
        Me.Name = "frmResultInput"
        Me.Controls.SetChildIndex(Me.btnF5, 0)
        Me.Controls.SetChildIndex(Me.lblState, 0)
        Me.Controls.SetChildIndex(Me.lblStateName, 0)
        Me.Controls.SetChildIndex(Me.btnStart, 0)
        Me.Controls.SetChildIndex(Me.btnFinish, 0)
        Me.Controls.SetChildIndex(Me.btnProduct, 0)
        Me.Controls.SetChildIndex(Me.lblProductPlan, 0)
        Me.Controls.SetChildIndex(Me.lblProcessName, 0)
        Me.Controls.SetChildIndex(Me.lblProcess, 0)
        Me.Controls.SetChildIndex(Me.lblProductName, 0)
        Me.Controls.SetChildIndex(Me.lblProductPlanNo, 0)
        Me.Controls.SetChildIndex(Me.lblCount, 0)
        Me.Controls.SetChildIndex(Me.btnF1, 0)
        Me.Controls.SetChildIndex(Me.btnF2, 0)
        Me.Controls.SetChildIndex(Me.btnF3, 0)
        Me.Controls.SetChildIndex(Me.btnF4, 0)
        Me.Controls.SetChildIndex(Me.lblProduct, 0)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblProcess As MESPdControl.CfLabel
    Friend WithEvents lblProductPlan As MESPdControl.CfLabel
    Friend WithEvents lblProductName As MESPdControl.CfLabel
    Friend WithEvents lblProcessName As MESPdControl.CfLabel
    Friend WithEvents lblProductPlanNo As MESPdControl.CfLabel
    Friend WithEvents lblCount As MESPdControl.CfLabel
    Friend WithEvents lblState As MESPdControl.CfLabel
    Friend WithEvents lblStateName As MESPdControl.CfLabel
    Friend WithEvents btnStart As MESPdControl.CfButton
    Friend WithEvents btnFinish As MESPdControl.CfButton
    Friend WithEvents btnProduct As MESPdControl.CfButton
    Friend WithEvents lblProduct As MESPdControl.CfLabel
End Class

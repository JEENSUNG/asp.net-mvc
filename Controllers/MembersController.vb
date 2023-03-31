Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports Enrollment
Imports Enrollment.Data

Namespace Controllers
    Public Class MembersController
        Inherits System.Web.Mvc.Controller

        Private db As New EFDbContext

        ' GET: Members
        Function Index() As ActionResult
            Return View(db.Members.ToList())
        End Function

        ' GET: Members/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim members As Members = db.Members.Find(id)
            If IsNothing(members) Then
                Return HttpNotFound()
            End If
            Return View(members)
        End Function

        ' GET: Members/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Members/Create
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Mem_Idx,Mem_MemberName,Mem_Password,Mem_Name,Mem_Major,Mem_Email,Mem_Date,Mem_Role,Mem_Credit,Mem_Grade,Mem_StudentIdx,Mem_Gender,Mem_Age,Mem_Updated,Mem_IsValid")> ByVal members As Members) As ActionResult
            If ModelState.IsValid Then
                db.Members.Add(members)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(members)
        End Function

        ' GET: Members/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim members As Members = db.Members.Find(id)
            If IsNothing(members) Then
                Return HttpNotFound()
            End If
            Return View(members)
        End Function

        ' POST: Members/Edit/5
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Mem_Idx,Mem_MemberName,Mem_Password,Mem_Name,Mem_Major,Mem_Email,Mem_Date,Mem_Role,Mem_Credit,Mem_Grade,Mem_StudentIdx,Mem_Gender,Mem_Age,Mem_Updated,Mem_IsValid")> ByVal members As Members) As ActionResult
            If ModelState.IsValid Then
                db.Entry(members).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(members)
        End Function

        ' GET: Members/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim members As Members = db.Members.Find(id)
            If IsNothing(members) Then
                Return HttpNotFound()
            End If
            Return View(members)
        End Function

        ' POST: Members/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim members As Members = db.Members.Find(id)
            db.Members.Remove(members)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace

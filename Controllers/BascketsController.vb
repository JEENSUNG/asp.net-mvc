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
    Public Class BascketsController
        Inherits System.Web.Mvc.Controller

        Private db As New EFDbContext

        ' GET: Basckets
        Function Index() As ActionResult
            Return View(db.Basckets.ToList())
        End Function

        ' GET: Basckets/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim basckets As Basckets = db.Basckets.Find(id)
            If IsNothing(basckets) Then
                Return HttpNotFound()
            End If
            Return View(basckets)
        End Function

        ' GET: Basckets/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Basckets/Create
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Bas_Idx,Bas_Name,Bas_Professor,Bas_Day,Bas_StartTime,Bas_EndTime,Bas_Credit,Bas_Subject,Bas_Updated,Bas_IsValid")> ByVal basckets As Basckets) As ActionResult
            If ModelState.IsValid Then
                db.Basckets.Add(basckets)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(basckets)
        End Function

        ' GET: Basckets/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim basckets As Basckets = db.Basckets.Find(id)
            If IsNothing(basckets) Then
                Return HttpNotFound()
            End If
            Return View(basckets)
        End Function

        ' POST: Basckets/Edit/5
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Bas_Idx,Bas_Name,Bas_Professor,Bas_Day,Bas_StartTime,Bas_EndTime,Bas_Credit,Bas_Subject,Bas_Updated,Bas_IsValid")> ByVal basckets As Basckets) As ActionResult
            If ModelState.IsValid Then
                db.Entry(basckets).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(basckets)
        End Function

        ' GET: Basckets/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim basckets As Basckets = db.Basckets.Find(id)
            If IsNothing(basckets) Then
                Return HttpNotFound()
            End If
            Return View(basckets)
        End Function

        ' POST: Basckets/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim basckets As Basckets = db.Basckets.Find(id)
            db.Basckets.Remove(basckets)
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

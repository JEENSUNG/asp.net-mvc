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
    Public Class SchedulesController
        Inherits System.Web.Mvc.Controller

        Private db As New EFDbContext

        ' GET: Schedules
        Function Index() As ActionResult
            Return View(db.Schedules.ToList())
        End Function

        ' GET: Schedules/Details/5
        Function Details(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim schedules As Schedules = db.Schedules.Find(id)
            If IsNothing(schedules) Then
                Return HttpNotFound()
            End If
            Return View(schedules)
        End Function

        ' GET: Schedules/Create
        Function Create() As ActionResult
            Return View()
        End Function

        ' POST: Schedules/Create
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Sch_Idx,Sch_Name,Sch_Professor,Sch_Day,Sch_StartTime,Sch_EndTime,Sch_Credit,Sch_Subject,Sch_Updated,Sch_IsValid")> ByVal schedules As Schedules) As ActionResult
            If ModelState.IsValid Then
                db.Schedules.Add(schedules)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(schedules)
        End Function

        ' GET: Schedules/Edit/5
        Function Edit(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim schedules As Schedules = db.Schedules.Find(id)
            If IsNothing(schedules) Then
                Return HttpNotFound()
            End If
            Return View(schedules)
        End Function

        ' POST: Schedules/Edit/5
        '초과 게시 공격으로부터 보호하려면 바인딩하려는 특정 속성을 사용하도록 설정하세요. 
        '자세한 내용은 https://go.microsoft.com/fwlink/?LinkId=317598을(를) 참조하세요.
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Sch_Idx,Sch_Name,Sch_Professor,Sch_Day,Sch_StartTime,Sch_EndTime,Sch_Credit,Sch_Subject,Sch_Updated,Sch_IsValid")> ByVal schedules As Schedules) As ActionResult
            If ModelState.IsValid Then
                db.Entry(schedules).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            Return View(schedules)
        End Function

        ' GET: Schedules/Delete/5
        Function Delete(ByVal id As Long?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim schedules As Schedules = db.Schedules.Find(id)
            If IsNothing(schedules) Then
                Return HttpNotFound()
            End If
            Return View(schedules)
        End Function

        ' POST: Schedules/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Long) As ActionResult
            Dim schedules As Schedules = db.Schedules.Find(id)
            db.Schedules.Remove(schedules)
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

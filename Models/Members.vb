Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.Data.Entity

Public Class Members
    <Key>
    <Required>
    Property Mem_Idx As Long

    <Display(Name:="아이디")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Mem_MemberName As String

    <Display(Name:="비밀번호")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Mem_Password As String

    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    <Display(Name:="이름")>
    Property Mem_Name As String

    <Display(Name:="전공")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(20, ErrorMessage:="최대 20자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Mem_Major As String

    <EmailAddress>
    <Display(Name:="이메일")>
    <Required, MinLength(2), MaxLength(20), RegularExpression("^([\w\.\_\-])*[a-zA-Z0-9]+([\w\.\_\-])*([a-zA-Z0-9])+([\w\.\_\-])+@([a-zA-Z0-9]+\.)+[a-zA-Z0-9]{2,8}$")>
    Property Mem_Email As String

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Mem_Created_Date As DateTime

    <DataType(DataType.Date)>
    <DisplayFormat(DataFormatString:="{0:yyyy-MM-dd}", ApplyFormatInEditMode:=True)>
    <Required>
    Property Mem_Modified_Date As DateTime

    <Required, MinLength(2), MaxLength(20), RegularExpression("^[A-Z]+[a-zA-Z]*$")>
    Property Mem_Role As String

    <Display(Name:="남은 학점")>
    <Required, Range(1, 200), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Mem_Credit As Integer

    <Display(Name:="학년")>
    <Required, Range(1, 6), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Mem_Grade As Integer

    <Display(Name:="학번")>
    <Required, Range(1, Integer.MaxValue), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Mem_StudentIdx As Long

    <Display(Name:="성별")>
    <Required, MinLength(2, ErrorMessage:="최소 2자는 입력되어야 합니다."), MaxLength(10, ErrorMessage:="최대 10자 까지만 작성 가능합니다."), RegularExpression("^[a-zA-Z가-힣]*$", ErrorMessage:="영어 또는 한글만 작성할 수 있습니다.")>
    Property Mem_Gender As String

    <Display(Name:="나이")>
    <Required, Range(1, 200), RegularExpression("^[0-9]*$", ErrorMessage:="숫자로만 입력 가능합니다.")>
    Property Mem_Age As Integer

    <Required, DefaultSettingValue("false")>
    Property Mem_Updated As Boolean

    <Required, DefaultSettingValue("false")>
    Property Mem_IsValid As Boolean

End Class

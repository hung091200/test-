<%@ page contentType="text/html;charset=UTF-8" language="java" %>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %><!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport"
          content="width=device-width, user-scalable=no, initial-scale=1.0, maximum-scale=1.0, minimum-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">
    <title>Document</title>
</head>
<body>
<div>
    <h2>Cập nhật nhân viên</h2>
    <form action="/nhan-vien/update" method="post">
        STT: <input type="number" name="stt" value="${nv.stt}"><br>
        Họ tên: <input type="text" name="hoten" value="${nv.hoten}"><br>
        Tuổi: <input type="number" name="tuoi" value="${nv.tuoi}"><br>
        SĐT: <input type="text" name="sdt" value="${nv.sdt}"><br>
        Giới tính: <input type="text" name="gioi_tinh" value="${nv.gioi_tinh}"><br>
        Phòng ban: <input type="text" name="phong_ban" value="${nv.phong_ban}"><br>
        Vị trí: <input type="text" name="vi_tri" value="${nv.vi_tri}"><br>
        <button type="submit">Lưu</button>
    </form>
</div>

</body>
</html>
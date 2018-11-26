<%@page import="java.util.*" language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@taglib uri="http://tiles.apache.org/tags-tiles" prefix="tiles"%>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<meta http-equiv="Content-Style-Type" content="text/css">
<link rel="stylesheet" href="/HDMS/theme/blue.css" type="text/css">
<tiles:getAsString name="documentTitle"></tiles:getAsString>
</head>
<body bgcolor="silver" vlink="silver" alink="aqua" link="#0080ff">
	<center>
		<table width="960" height="100%" cellspacing="0" cellpadding="0"
			border="0">
			<tbody>
				<tr>
					<td valign="top">
						<table class="header" cellspacing="0" cellpadding="0" border="0"
							width="100%">
							<tbody>
								<tr>
									<td width="100%"><h1 align="center">
											<font face="Stencil">HOSPITAL DEVICE MANAGEMENT SYSTEM</font>
										</h1>
									</td>
									<td></td>
								</tr>
							</tbody>
						</table></td>
				</tr>
				<tr>
					<td valign="middle" class="nav_head" height="30"
						style="padding-left: 10px; padding-right: 10px">
						<table cellpadding="0" cellspacing="1" bgcolor="black" width="100%">
							<tbody>
								<tr>
									<td><b><b><font face="@Adobe Fan Heiti Std B"
												color="white"><a href="${pageContext.request.contextPath}/index.jsp">Home</a> | <a
													href="${pageContext.request.contextPath}/DeviceCatalogue.jsp">Devices</a>
													| <a href="${pageContext.request.contextPath}/contact.jsp">Contact</a>
											</font> </b>
									</b>
									</td>
									<td align="right"><font color="white"><%
			if((session.getAttribute("username")!=null))
			{
			%>
				<b> <%= session.getAttribute( "username" ) %> </b>  | <a href="logout.jsp" >Logout</a>
			<%
			}
			%></font>
									</td>
								</tr>
							</tbody>
						</table></td>
				</tr>
				
				<tr class="content-area" >
				
					<td valign="top" height="100%" align="left" style="padding: 10px"><tiles:insertAttribute
							name="bodyarea"></tiles:insertAttribute>
					</td>
				</tr>
				<tr>
					<td valign="middle" height="25" class="footer" align="center">&copy
						2012 HDMS CORPORATION</td>
				</tr>
			</tbody>
		</table>
	</center>
</body>
</html>
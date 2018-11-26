<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@taglib uri="http://tiles.apache.org/tags-tiles" prefix="tiles"%>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<meta http-equiv="Content-Style-Type" content="text/css">
<link rel="stylesheet" href="/HDMS/theme/blue.css" type="text/css">


<tiles:getAsString name="documentTitle"></tiles:getAsString>
</head>
<body bgcolor="silver">
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
						style="padding-left: 10px; padding-right: 10px"><table
							cellpadding="0" cellspacing="1" bgcolor="black" width="100%">
							<tbody>
								<tr>
									<td><b><b><font face="@Adobe Fan Heiti Std B"
												color="white"><a href="../index.jsp">Home</a> | <a
													href="${pageContext.request.contextPath}/DeviceCatalogue.jsp">Devices</a>
													| <a href="${pageContext.request.contextPath}/contact.jsp">Contact</a>
											</font> </b> </b></td>
									<td align="right"><font color="white">
											<%
			if((session.getAttribute("username")!=null))
			{
			%> <b> <%= session.getAttribute( "username" ) %> </b> | <a href="logout.jsp">Logout</a>
											<%
			}
			%>
									</font></td>
								</tr>
							</tbody>
						</table></td>
				</tr>
				
				<tr class="content-area">
				
					<td valign="top" height="100%" align="left">
					<table height="100%" width="100%">
							<tbody>
								<tr align="center">
									<td height="100%" width="20%" valign="top" bgcolor="#f0f0f0" align="center"><div align="left"><table border="0" cellspacing="6" width="100%">
											<tbody>
												<tr>
													<td><font color="silver">.</font>
														</td>
												</tr>
												<tr>
													<td><a
															href="${pageContext.request.contextPath}/mpregdr.jsp">Registered
																Doctors</a><a
															href="${pageContext.request.contextPath}/mpregdr.jsp">
														</a>
														</td>
												</tr>
												<tr>
													<td></td>
												</tr>
												<tr>
													<td><a href="${pageContext.request.contextPath}/drdreq.jsp"></a></td>
												</tr>
												<tr>
													<td></td>
												</tr>
												<tr>
													<td><a	href="${pageContext.request.contextPath}/mpdrreq.jsp">Doctors Request</a></td>
												</tr>
											</tbody>
										</table></div>
									</td>
									<td class="BodyArea" height="100%" valign="top" width="80%"
										align="left" style="padding: 10px"><tiles:insertAttribute name="bodyarea"></tiles:insertAttribute>
									</td>
								</tr>
							</tbody>
						</table>
										
					</td>
				</tr>
				<tr>
					<td valign="middle" height="25" class="footer" align="center">
						2012 HDMS CORPORATION</td>
				</tr>
			</tbody>
		</table>
	</center>
</body>
</html>
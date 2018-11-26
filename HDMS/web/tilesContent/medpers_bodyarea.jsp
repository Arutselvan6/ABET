<%@page language="java" import="java.util.*" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<p>
	<font color="white">.</font> Welcome to <%= session.getAttribute( "username" ) %> !</p>

<table align="center">
	<tr>
		<td><h2>
				<font color="white">.</font>
			</h2>
			<font color="white"> </font>
			<h2>
				<font color="white">.</font>
			</h2>
		</td>
	</tr>
</table>
<center><table border="0" cellpadding="5" cellspacing="5" width="700">
	<tbody>
		<tr>
			<td align="center"><font size="+2"></font><a
					href="${pageContext.request.contextPath}/devices.jsp"><img
						border="0" src="${pageContext.request.contextPath}/microscope.png"
						width="128" height="128">
				</a></td><td align="center"><font size="+2"><a
						href="${pageContext.request.contextPath}/mpdoctor.jsp"></a></font><a
					href="${pageContext.request.contextPath}/mpdoctor.jsp"><img
						border="0" src="${pageContext.request.contextPath}/images/dr.png"
						width="128" height="128">
				</a></td>
				<td align="center"><a
					href="${pageContext.request.contextPath}/mpfd.jsp"><img
						border="0" src="${pageContext.request.contextPath}/images/fd.png"
						width="128" height="128">
				</a></td>
			</tr>
			<tr>
				<td align="center" valign="middle"><font size="+2"><a href="devices.jsp">DEVICES</a> </font>
				</td>
				<td align="center" valign="middle"><font size="+2"><a
						href="${pageContext.request.contextPath}/mpregdr.jsp">DOCTORS</a>
				</font></td>
				<td align="center" valign="middle"><font size="+2"><a href="mpfd.jsp">FINANCE DEPTT.</a> </font></td>
			</tr>
		</tbody>
</table></center>
<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
	
	
	
<p>Welcome to <%= session.getAttribute( "username" ) %> !</p>

<table align="center">

	<tr>
		<td><h2>
				<font color="white">.</font>
			</h2>
			<font color="white"> .</font>
			<h2>
				<font color="white">.</font>
			</h2>
		</td>
	</tr>
</table>
<center><table border="0" cellpadding="5" cellspacing="5" width="600">
	<tbody>
			<tr>
				<td align="center"><a
					href="${pageContext.request.contextPath}/drdavail.jsp"><img
						border="0" src="${pageContext.request.contextPath}/medkit.png"
						width="64" height="64">
				</a><font size="-1"><a href="../deviceavail.jsp"></a>
				</font></td>
				<td align="center"><font size="-1"><a href="../devicedetails.jsp"></a>
				</font><a href="${pageContext.request.contextPath}/drdinfo.jsp"><img
						border="0" src="${pageContext.request.contextPath}/clipboard.png"
						width="64" height="64">
				</a>
				</td>
				<td align="center"><font size="-1"><a href="../devicereq.jsp"></a>
				</font><a href="${pageContext.request.contextPath}/drdreq.jsp"><img
						border="0"
						src="${pageContext.request.contextPath}/ambulance car.png"
						width="64" height="64">
				</a>
				</td>
			</tr>
			<tr>
			<td><font size="+1"><a
						href="${pageContext.request.contextPath}/drdavail.jsp">DEVICE
							AVAILABLE</a>
				</font></td>
			<td><font size="+1"><a
						href="${pageContext.request.contextPath}/drdinfo.jsp">DEVICE
							DETAILS</a>
				</font></td><td><font size="+1"><a
						href="drdreq.jsp">DEVICE REQUEST</a> </font>
				</td>
			</tr>
	</tbody>
</table></center>
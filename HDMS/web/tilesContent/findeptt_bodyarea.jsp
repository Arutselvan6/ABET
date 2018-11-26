<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<p>Welcome to
	<%= session.getAttribute( "username" ) %>    </p>
<p>
	<table align="center">
		<tr>
			<td><h2>
					<font color="white">.</font>
				</h2> <font color="white"> .</font>
				<h2>
					<font color="white">.</font>
				</h2></td>
		</tr>
	</table>
</p>
<center><table border="0" cellspacing="5" width="700">
	<tbody align="center">
			<tr>
				<td><img border="0" src="${pageContext.request.contextPath}/ecg.png"
					width="64" height="64">
				</td>
				<td><img border="0"
					src="${pageContext.request.contextPath}/clipboard.png" width="64"
					height="64">
				</td>
				<td><img border="0"
					src="${pageContext.request.contextPath}/caduceus.png" width="64"
					height="64">
				</td>
			</tr>
			<tr>
			<td><font size="+1">ROI Evaluation</font></td>
			<td><font size="+1">Device Purchase Request</font></td>
			<td><font size="+1">Device Purchase History</font></td>
		</tr>
	</tbody>
</table></center>
<p></p>


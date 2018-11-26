<%response.setHeader("Cache-Control","no-cache"); //Forces caches to obtain a new copy of the page from the origin server
response.setHeader("Cache-Control","no-store"); //Directs caches not to store the page under any circumstance
response.setDateHeader("Expires", 0); //Causes the proxy cache to see the page as "stale"
response.setHeader("Pragma","no-cache"); //HTTP 1.0 backward compatibility
String userName = (String) session.getAttribute("username");
if (null == userName) {
   request.setAttribute("Error", "Session has ended.  Please login.");
   RequestDispatcher rd = request.getRequestDispatcher("index.jsp");
   rd.forward(request, response);
}%>
<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><%@taglib
	uri="http://tiles.apache.org/tags-tiles" prefix="tiles"%><tiles:insertDefinition
	name="bluedr">
	<tiles:putAttribute name="documentTitle" type="string">
		<title>drdinfo</title>
		<meta http-equiv="Content-Type"
			content="text/html; charset=ISO-8859-1">
	</tiles:putAttribute>
	<tiles:putAttribute name="bodyarea"
		value="/tilesContent/drdinfo_bodyarea.jsp" type="template"></tiles:putAttribute>
</tiles:insertDefinition>
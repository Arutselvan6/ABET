<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><%@taglib
	uri="http://tiles.apache.org/tags-tiles" prefix="tiles"%><tiles:insertDefinition
	name="bluelogout">
	<tiles:putAttribute name="documentTitle" type="string">
		<title>logout</title>
		<meta http-equiv="Content-Type"
			content="text/html; charset=ISO-8859-1">
	</tiles:putAttribute>
	<tiles:putAttribute name="bodyarea"
		value="/tilesContent/logout_bodyarea.jsp" type="template"></tiles:putAttribute>
</tiles:insertDefinition>
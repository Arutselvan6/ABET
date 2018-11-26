<%@page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%><%@taglib
	uri="http://tiles.apache.org/tags-tiles" prefix="tiles"%><tiles:insertDefinition
	name="A_blue">
	<tiles:putAttribute name="documentTitle" type="string">
		<title>register</title>
		<meta http-equiv="Content-Type"
			content="text/html; charset=ISO-8859-1">
	</tiles:putAttribute>
	<tiles:putAttribute name="bodyarea"
		value="/tilesContent/register_bodyarea.jsp" type="template"></tiles:putAttribute>
</tiles:insertDefinition>
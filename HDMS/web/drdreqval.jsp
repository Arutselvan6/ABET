<%@page import="java.sql.*" language="java"
	contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1"%><%@taglib
	uri="http://tiles.apache.org/tags-tiles" prefix="tiles"%><tiles:insertDefinition
	name="A_blue">
	<tiles:putAttribute name="documentTitle" type="string">
		<title>drdreqval</title><jsp:useBean id="db"
			class="database.DataConnect"></jsp:useBean>
		<meta http-equiv="Content-Type"
			content="text/html; charset=ISO-8859-1">
	</tiles:putAttribute>
	<tiles:putAttribute name="bodyarea"
		value="/tilesContent/drdreqval_bodyarea.jsp" type="template"></tiles:putAttribute>
</tiles:insertDefinition>
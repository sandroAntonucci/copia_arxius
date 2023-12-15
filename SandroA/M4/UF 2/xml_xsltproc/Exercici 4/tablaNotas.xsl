<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">

        <html>

        <body>
            <table border="1">
                <tr bgcolor="#9acd32">
                    <th style="text-align:center">Nombre</th>
                    <th style="text-align:center">Apellidos</th>
                    <th style="text-align:center">Telefono</th>
                    <th style="text-align:center">Repetidor</th>
                    <th style="text-align:center">Nota total</th>
                </tr>
                <xsl:for-each select="evaluacion/alumno">
                <xsl:sort select="nombre" />
                    <tr>
                        <td><xsl:value-of select="nombre"/></td>
                        <td><xsl:value-of select="apellidos" /></td>
                        <td><xsl:value-of select="telefono" /></td>
                        <td><xsl:value-of select="@repite" /></td>
                            <xsl:choose>
                                <xsl:when test="((practicas)+examen) div 2 &lt; 5">
                                    <td style="Background-color:red"><xsl:value-of select="(practicas+examen) div 2" /></td>
                                </xsl:when>
                                <xsl:otherwise>
                                    <td style="Background-color:lightblue"><xsl:value-of select="(practicas+examen) div 2" /></td>

                                </xsl:otherwise>
                            </xsl:choose>
                    </tr>
                </xsl:for-each>
            </table>
        </body>

        </html>
    </xsl:template>
</xsl:stylesheet>
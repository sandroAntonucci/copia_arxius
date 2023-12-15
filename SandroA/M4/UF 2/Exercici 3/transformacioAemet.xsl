<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:template match="/">

        <html>

        <body>
            <table border="1">
                <tr>
                    <th style="text-align:center">Fecha</th>
                    <th style="text-align:center">Maxima</th>
                    <th style="text-align:center">Minima</th>
                    <th style="text-align:center">Prediccion</th>
                </tr>
                <xsl:for-each select="//dia">
                    <tr>
                        <td><xsl:value-of select="@fecha" /></td>
                        <td><xsl:value-of select="temperatura/maxima" /></td>
                        <td><xsl:value-of select="temperatura/minima" /></td>
                        <td>
                            <img src="{concat('imagenes/',estado_cielo/@descripcion)}.png" width="50px" height="50px"/>
                        </td>
                    </tr>
                </xsl:for-each>
            </table>
        </body>

        </html>
    </xsl:template>
</xsl:stylesheet>
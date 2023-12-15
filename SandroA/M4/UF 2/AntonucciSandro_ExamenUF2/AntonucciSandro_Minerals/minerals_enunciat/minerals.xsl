<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
    <xsl:template match="/"> <!--comencem a treballar per l'arrel, minerals-->
    <html>
        <head>
            <link rel="stylesheet" type="text/css" href="style.css" />
        </head>

        <body>
            <header>
                <h1>MINERALS</h1>
            </header>

            <xsl:for-each select="minerals/mineral">
            
                <table border="1" id="header">

                    <tr>
                        <td><b><xsl:value-of select="nom"/></b></td>
                        <td><b>ID:</b><xsl:value-of select="@Id"/></td>
                        <td><b>NOM: </b><xsl:value-of select="nom"/></td>
                        <td><b>COMPOSICIO: </b><xsl:value-of select="composicio"/></td>
                        <td><b>GRUP: </b><xsl:value-of select="grup"/></td>
                    </tr>

                </table>

                <table border="1" id="info">

                    <tr>
                        <td><b>Densitat:</b> <xsl:value-of select="densitat"/></td>
                        <td rowspan="5"><img src="{concat('img/',foto)}"/></td>
                    </tr>
                    <tr>
                        <td><b>Duresa:</b> <xsl:value-of select="duresa"/></td>
                    </tr>
                    <tr>
                        <td><b>Exfoliacio:</b> <xsl:value-of select="exfoliacio"/></td>
                    </tr>
                    <tr>
                        <td><b>Color:</b> <xsl:value-of select="color"/> <b> Ratlla:</b> <xsl:value-of select="ratlla"/></td>
                    </tr>
                    <tr>
                        <td><b>Lluissor:</b> <xsl:value-of select="lluissor"/></td>
                    </tr>
                
                </table>

        </xsl:for-each>
    </body>
    </html>
</xsl:template>
</xsl:stylesheet>
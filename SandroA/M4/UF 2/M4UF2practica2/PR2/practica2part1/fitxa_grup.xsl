<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/"> <!--comencem a treballar per l'arrel -->
   
      <xsl:for-each select="grups/grup"> <!--amb al for-each fem com un bucle, com tenim més d'un grup, demanem que es repeteixi per tants grups com tinguem, si només en tenim un, en farà un-->
           
           <article class="info">

              <xsl:element name="a">
                    <xsl:attribute name="href"><xsl:value-of select="informacio_general/enllac"/></xsl:attribute>
                    <h3><xsl:value-of select="nom" /></h3>
              </xsl:element>

              <p id="fecha"><xsl:value-of select="@fecha"/></p>
              <p><xsl:value-of select="informacio_general/descripcio"/></p>
              <p>Precio: <xsl:value-of select="informacio_general/preu"/> - Duración: <xsl:value-of select="informacio_general/dies"/></p>
              <img src="{concat('imagenes/',foto)}.jpg"/>
              
           </article>    
      </xsl:for-each> 
    </xsl:template>
</xsl:stylesheet>

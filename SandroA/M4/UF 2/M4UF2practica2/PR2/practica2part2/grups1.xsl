<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>

    <head>
      <meta charset="UTF-8" />
      <title>ITB Tours</title>

      <link rel="stylesheet" href="itinerari.css" />

    </head>

    <body>
      <header>
        <img alt="logo ITB" src="img/logoitb.jpeg" />
      </header>

      <nav id="fijo">
        <ul class="menunav">
          <li> <a href="#">inicio</a></li>
          <li> <a href="#">grupos propios</a></li>
          <li> <a href="#">viajes a medida</a></li>
          <li> <a href="#">cruceros</a></li>
          <li> <a href="#">ofertas</a></li>
          <li> <a href="#">contacto</a></li>

        </ul>
      </nav>
      <section>
        <xsl:for-each select="grups/grup">

          <article>
            <h1 class="titol"><xsl:value-of select="nom" /> - <xsl:value-of select="@fecha" /></h1>
            <img id="rioja" alt="" src="img/rioja.jpeg" width="20%" height="500px" />
            <div class="info">
              <p><b>Grupo mínimo: </b><xsl:value-of select="informacio_general/grupMin" /></p>
              <p><b>Precio: </b> <xsl:value-of select="informacio_general/preu" /> <b>Duracion:</b> <xsl:value-of
                  select="informacio_general/dies" /></p>
            </div>
            <div class="info_general">
              <h2><b>El viaje incluye:</b></h2>
              <xsl:for-each select="inclos/inclou">
                <p><br /><xsl:value-of select="." /></p>
              </xsl:for-each>
            </div>
          </article>

          <div class="itinerari">
            <h2>Itinerario: </h2>
            <xsl:for-each select="itinerari/dia">
              <article>
                <p><br/><xsl:value-of select="titol" /> - <xsl:value-of select="desc" /></p>
              </article>
            </xsl:for-each>
          </div>
        </xsl:for-each>
      </section>
    </body>

    </html>
  </xsl:template>
</xsl:stylesheet>
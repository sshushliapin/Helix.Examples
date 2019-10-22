ARG REGISTRY
ARG WINDOWSSERVERCORE_VERSION
ARG SITECORE_VERSION

FROM ${REGISTRY:-}sitecore-xm-cm:${SITECORE_VERSION}-windowsservercore-${WINDOWSSERVERCORE_VERSION}

WORKDIR /inetpub/wwwroot
#COPY ./scripts/Invoke-XdtTransform.ps1 ./App_Config
COPY ./website .
#COPY ./web.debug.config ./temp/transforms
#RUN powershell -NoProfile -NoLogo -File ./App_Config/Invoke-XdtTransform.ps1 -Path ./Web.config -Destination ./Web.config -Xdt ./temp/transforms/web.debug.config;
# RUN rm ./App_Config/Invoke-XdtTransform.ps1; \
#     rm ./bin/Microsoft.Web.XmlTransform.*; \
#     rm -r ./temp/transforms
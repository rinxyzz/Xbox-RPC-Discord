<?xml version="1.0" encoding="utf-8" ?>
 <configuration>
   <appSettings>
     <add key="countoffiles" value="7" />
     <add key="logfilelocation" value="dir.js" />
   </appSettings>
 </configuration>

 using System.Configuration;

 string configXbox = ConfigurationManager.AppSettings["countoffiles"];
 string configvalue = ConfigurationManager.AppSettings["logfilelocation"];
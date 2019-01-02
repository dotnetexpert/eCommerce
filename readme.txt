1. My name : Tejinder Singh
2. Brief instructions for using solution 
i). I am sending database script to create database & requires schema.
ii). Please change add DataSource in <connection string> tag of Web.Config file.  

3. Mechanism I have adopted for handling bad data
    For now I have used try & catch to handle bad data ( But can be use validations at front end. I have not much time to do so).

4. Libraries used in project and the reason for their use
   No, third party library used. Only Microsoft's & Angular's library are used 

5. A brief explanation of the architecture and methodologies used within solution
    I have used Three Tier architecture to modularize user interface, business logic layer and data storage layers.
       i). eCommerce.BLL for Business Logic Layer
       ii). eCommerce.DAL for Data Access Layer
       iii). Presentation Layer

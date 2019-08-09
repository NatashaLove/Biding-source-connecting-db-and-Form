# Biding-source-connecting-db-and-Form
windows forms and db / bindingSource and DAtaSet

binding source always necessary between db (table) and the form -
         into which we are trying to get info from the db - it's the connection/
        because we can't transfer data directly from db into the form.
        
        Dataset is used to hold tables with data. You can select data form tables, 
        create views based on table and ask child rows over relations.
        
        The ADO.NET DataSet contains DataTableCollection and their DataRelationCollection . 
        It represents a complete set of data including the tables that contain, order, 
        and constrain the data, as well as the relationships between the tables. 
        We can use Dataset in combination with DataAdapter Class.

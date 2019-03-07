select * from iitables where table_type = 'T' and table_owner='ingres'

select * from iicolumns where table_name ='pvafxtmp'

select column_name, 
case 
	when column_datatype = 'CHAR' then column_datatype || '(' || RTRIM(column_length) || ')' 
	else column_datatype
end as typeInfo
	from iicolumns where table_name ='pvafxtmp'


select 1 = 2
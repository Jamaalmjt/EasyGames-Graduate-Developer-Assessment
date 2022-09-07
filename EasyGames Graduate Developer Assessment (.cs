CREATE TABLE Person (
    PersonID int PRIMARY KEY IDENTITY(1,1),
    LastName varchar(255),
    FirstName varchar(255),
    Address varchar(255),
    City varchar(255),
	Age INT
    AMOUNT(255)
    CLIENTBALANCE(255)
)
 
GO
 
INSERT INTO Person VALUES('Hayes', 'Corey','123  Wern Ddu Lane','LUSTLEIGH',23, R8000)
INSERT INTO Person VALUES('Macdonald','Charlie','23  Peachfield Road','CEFN EINION',45, R18000)
INSERT INTO Person VALUES('Frost','Emma','85  Kingsway North','HOLTON',26, R57000)
INSERT INTO Person VALUES('Thomas', 'Tom','59  Dover Road', 'WESTER GRUINARDS',51, R120000)
INSERT INTO Person VALUES('Baxter','Cameron','106  Newmarket Road','HAWTHORPE',46,R87000)
INSERT INTO Person VALUES('Townsend','Imogen ','100  Shannon Way','CHIPPENHAM',20, R33000)
INSERT INTO Person VALUES('Preston','Taylor','14  Pendwyallt Road','BURTON',19,R19000)
INSERT INTO Person VALUES('Townsend','Imogen ','100  Shannon Way','CHIPPENHAM',18,R15000)
INSERT INTO Person VALUES('Khan','Jacob','72  Ballifeary Road','BANCFFOSFELEN',11,R9000)

SET IMPLICIT_TRANSACTIONS ON 
UPDATE 
    Person 
SET 
    Lastname = 'Sawyer', 
    Firstname = 'Tom' 
WHERE 
    PersonID = 2 
SELECT 
    IIF(@@OPTIONS & 2 = 2, 
    'Implicit Transaction Mode ON', 
    'Implicit Transaction Mode OFF'
    ) AS 'Transaction Mode' 
SELECT 
    @@TRANCOUNT AS OpenTransactions 
COMMIT TRAN 
SELECT 
    @@TRANCOUNT AS OpenTransactions


5BEGIN TRAN
 
UPDATE Person 
SET    Lastname = 'Lucky', 
        Firstname = 'Luke' 
WHERE  PersonID = 1
 
SELECT @@TRANCOUNT AS OpenTransactions

BEGIN TRAN
UPDATE Person 
SET    Lastname = 'Donald', 
        Firstname = 'Duck'  WHERE PersonID=2
 
 
SELECT * FROM Person WHERE PersonID=2
 
ROLLBACK TRAN 
 
SELECT * FROM Person WHERE PersonID=2

<select id="dropdown"></select>
<script>
  $(document).ready(function(){
    $('#dropdown').kendoDropDownList({
      dataTextField: 'text',
      dataValueField: 'value',
      dataSource: [
        { text: 'item 1', value: 1 },
        { text: 'item 2', value: 2 },
        { text: 'item 3', value: 3 }
      ]
    });
  });
</script>
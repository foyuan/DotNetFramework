Create table Product
(
ProductId char(32),--��Ʒid
Name varchar(150),--��Ʒ����
Url varchar(200),--�ɼ�url
CategoryId int,--����
Supplier int,--������
Inventory int,--���
CommentNumber int,--������
InDate Datetime,--¼��ʱ��
EditDate Datetime,--�༭ʱ��
)

Create table ProductPriceHistory
(
ProdoutId char(32),--��Ʒguid
GatherDate datetime,--�ɼ�ʱ��
Price Decimal,--�۸�
PriceImage varchar(255),--�۸�ͼƬ ÿ�ڵĵ�ַҪ��һ��
PriceCheck Decimal,--�۸���
PromotionInfo varchar(500)--������Ϣ
)

Create table ProductCategory
(
CategoryId varchar(32),
Name varchar(100),
ParentId varchar(32),
Url varchar(200)
)

Create table ProductCategoryPath
(
[Ancestor] [varchar](32) NOT NULL,
[Descendant] [varchar](32) NOT NULL
)

--�ɼ�����
Create table GetherSite
(
SiteId int,
Name varchar(50)
)
Create Table GatherConfig
(

)
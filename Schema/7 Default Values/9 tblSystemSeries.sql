--Transactions
EXEC uspAddSystemSeries 'JV' --Journal Voucher

EXEC uspAddSystemSeries 'B' --Bills
EXEC uspAddSystemSeries 'BP' --Bills Payment
EXEC uspAddSystemSeries 'CV' --Check Voucher

EXEC uspAddSystemSeries 'SI' --Sales Invoice
EXEC uspAddSystemSeries 'CR' --Cash Receipt
EXEC uspAddSystemSeries 'CRV' --Cash Receipt Voucher

--Journals
EXEC uspAddSystemSeries 'GJ' --General Journal
EXEC uspAddSystemSeries 'PJ' --Purchase Journal
EXEC uspAddSystemSeries 'SJ' --Sales Journal
EXEC uspAddSystemSeries 'CRJ' --Cash Receipt Journal
EXEC uspAddSystemSeries 'CDJ' --Cash Disbursement Journal

--Others
EXEC uspAddSystemSeries 'COP' --Customer Overpayment
GO


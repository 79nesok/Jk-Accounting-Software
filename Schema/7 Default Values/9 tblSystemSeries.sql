--Vouchers
EXEC uspAddSystemSeries 'JV' --Journal Voucher
EXEC uspAddSystemSeries 'B' --Bills
EXEC uspAddSystemSeries 'SI' --Sales Invoice
EXEC uspAddSystemSeries 'CR' --Cash Receipt
EXEC uspAddSystemSeries 'BP' --Bills Payment

--Journals
EXEC uspAddSystemSeries 'GJ' --General Journal
EXEC uspAddSystemSeries 'PJ' --Purchase Journal
EXEC uspAddSystemSeries 'SJ' --Sales Journal
EXEC uspAddSystemSeries 'CRJ' --Cash Receipt Journal
EXEC uspAddSystemSeries 'CDJ' --Cash Disbursement Journal

--Others
EXEC uspAddSystemSeries 'COP' --Customer Overpayment
GO


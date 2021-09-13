import smtplib
s=smtplib.SMTP('smtp.gmail.com',587)
s.starttls()
s.login("your_email-id","your_password")
message="""\
Subject: "Jenkins mlops job notification"

The model is created successfully and accuracy is more than 98%.
"""
s.sendmail("your_email-id","receiver_email-id",message)
s.quit()

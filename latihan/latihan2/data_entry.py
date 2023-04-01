import tkinter
from tkinter import ttk

window = tkinter.Tk()
window.title("Data Entry Form")

frame = tkinter.Frame(window)
frame.pack()

# saving user info
userInfoFrame = tkinter.LabelFrame(frame, text="User Information")
userInfoFrame.grid(row=0, column=0, padx=20, pady=20)

firstNameLabel = tkinter.Label(userInfoFrame, text="First Name")
firstNameLabel.grid(row=0, column=0)
firstNameEntry = tkinter.Entry(userInfoFrame)
firstNameEntry.grid(row=1, column=0)

lastNameLabel = tkinter.Label(userInfoFrame, text="Last Name")
lastNameLabel.grid(row=0, column=1)
lastNameEntry = tkinter.Entry(userInfoFrame)
lastNameEntry.grid(row=1, column=1)

titleLabel = tkinter.Label(userInfoFrame, text="Title")
titleLabel.grid(row=0, column=2)
titleCombo = ttk.Combobox(userInfoFrame, values=["", "Mr.", "Mrs.", "Dr."])
titleCombo.grid(row=1, column=2)

ageLabel = tkinter.Label(userInfoFrame, text="Age")
ageLabel.grid(row=2, column=0)
ageSpinbox = tkinter.Spinbox(userInfoFrame, from_=18, to=100)
ageSpinbox.grid(row=3, column=0)

nationalityLabel = tkinter.Label(userInfoFrame, text="Nationality")
nationalityLabel.grid(row=2, column=1)
nationalityCombo = ttk.Combobox(userInfoFrame, values=["Indonesia", "Malaysia", "Brunei", "Laos"])
nationalityCombo.grid(row=3, column=1)

for widget in userInfoFrame.winfo_children():
    widget.grid_configure(padx=10, pady=5)

# saving courses info
coursesFrame = tkinter.LabelFrame(frame)
coursesFrame.grid(row=1, column=0, sticky="news", padx=20, pady=20)

registrationLabel = tkinter.Label(coursesFrame, text="Registration Status")
registrationLabel.grid(row=0, column=0)
registrationCheck = tkinter.Checkbutton(coursesFrame, text="Currently Registered")
registrationCheck.grid(row=1, column=0)

window.mainloop()
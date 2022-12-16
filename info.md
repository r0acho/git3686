# A Non-Definitive Beginner's Guide to Git 
## Section 1: Commands
* **git init:** Starts up Git in VS Code Terminal

* **git status:** Outputs information about the current status of Git

* **git add _[folder/file name]_:** Adds a file/folder to track and commit

* **git commit -m "_[message]_":** Saves the state of the file/folder along with a brief message

* **git commit -am "_[message]_":** Essentialy, combines two commands (git add and git commit) into one

* **git log:** Displays all previous commits of a file

* **git checkout _[first four symbols of a commit]_:** Used to move from one commit/branch to the other

* **git checkout master:** Sends you back to your main branch/current (main) commit

* **git diff:** Highlights the differences between the current file and a chosen commit

* **git branch:** Is used to view existing branches

* **git branch _[new branch name]_:** Is used to create a new branch from the current commit

* **git checkout -b _[new branch name]_:** Creates a new branch and checks out onto it

* **git branch -d _[deletable branch name]_:** Deletes the stated branch

* **git merge _[branch name]_:** Merges current branch with the inputted one

* **git clone _[url]_:** Copies the repository from GitHub onto the local hardware

* **git push:** Uploads the commit and its changes onto GitHub

* **git pull:** Imports the changes made to the repositorium on GitHub


> ![_What a wonderful world~_](Commited.webp)

## Section 2: Markdown

* **"# "** - makes something into a title

* **"## "** - makes something into a subtitle

* "**" - makes something bold

* **"_"** - makes something italic

* **">"** - makes something into a quote style

* "* " - makes something into a bullet list

* **1, 2, 3...** - makes something into a numbered list

* **[example] (link)** - makes something into a hyperlink

* **! [img]** - pulls the link and displays an image

## Section 3: GitHub (Contributions)
You first need to fork out a repositorium you'd like to make a contribution to. Get an https link from that forked repositorium and use "git clone [url]" in order to import it onto your local hardware and VS Code. Make changes to it, then add and commit. Push the commit to your repositorium, and then click "contribute" on the original code, forming a pull request.
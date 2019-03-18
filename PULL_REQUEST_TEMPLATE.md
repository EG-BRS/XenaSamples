# Code Quality
- [ ] Tests are written for the features.
- [ ] Reasonable logging have been added to the code.
- [ ] I have compiled and tested my own code.

# Deployment
- [ ] Moved Jira issue [BRS-xxx](https://eg-xena.atlassian.net/browse/BRS-xxx) to "Code complete".
- [ ] Issue [BRS-xxx](https://eg-xena.atlassian.net/browse/BRS-xxx) needs to be merged before merging this PR.
- [ ] If accepted, reviewer can merge this PR.
- [ ] This branch can be deleted after merge.

# Changes
- Write a short description of the change.

GDPR
======
Only fill out this part if the PR is a GDPR change. A PR is a GDPR change if:
* It touches any General personal data or Sensitivity personal data
* All changes to the Ids, Payroll (backend and frontend) and Partners (Xena)

__Always add 'GDPR' label to PR!__

Change type (select one):
- [ ] Normal Change
  - [ ]  Minor change
  - [ ]  significant change
  - [ ]  major change
- [x] Standard Change (Only minor changes)
- [ ] Emergency Change

More info on change types [here](https://github.com/EG-BRS/Documentation/wiki/Definition-of-GDPR-change)

Other:
- [ ] I have add the GDPR label to this PR.
- [ ] A risk analysis have been add to the Jira task.
- [ ] A test plan have been add to the Jira task.
- [ ] A post implementation test is needed. Write it on the jira.
- [x] All communication is done with encryption (https).
- [x] All Sensitivity personal data is encrypted in the DB. 
- [x] All viewing, searching, changesing and deletions of ['GDPR sensitive data'](https://github.com/EG-BRS/Documentation/blob/master/GDPR/Datatypes-examples.md) is logged.
- [ ] Will this PR added any new 'Sensitivity personal data' to our systems? __If YES, @thehusted must be added as reviewer.__


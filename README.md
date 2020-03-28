[![Build Status](https://dev.azure.com/ple0049/ple0049/_apis/build/status/Forcoa-NET.Non-symmetricDependency?branchName=master)](https://dev.azure.com/ple0049/ple0049/_build/latest?definitionId=1&branchName=master)
![Azure DevOps coverage](https://img.shields.io/azure-devops/coverage/ple0049/1948078f-2e6c-4abe-b86e-16a823fd37a2/1)
![Azure DevOps tests](https://img.shields.io/azure-devops/tests/ple0049/1948078f-2e6c-4abe-b86e-16a823fd37a2/1)

# Non-Symmetric Structural Dependency

This repository contains implementation of non-symmetric structural similarity between pairs of nodes, which we refer to as dependency. This dependency can be used, thanks to non-symmetry, to accurately describe the prominent nodes in the zones which are responsible for large zone overlaps and the reasons why overlaps occur.

More background information and specific use case can be found in the original [article](https://appliednetsci.springeropen.com/articles/10.1007/s41109-019-0192-6).

## Algorithm

This repository contains implementation of algorithm by following definition.

![Definition of Dependency](Description.PNG "Definition of Dependency")


## Contribution

Author: Milos Kudelka - milos.kudelka@vsb.cz

Implementation: Jakub Plesník - jakub.plesnik.st@vsb.cz

Fell free to create pull request with fixes or enhancements.

## Disclaimer

Algorithm is implemented with focus on readability so there is minimum of performance optimalizations.

## Licence

The algorithm is published under MIT licence.

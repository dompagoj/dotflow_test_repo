pipeline {
  agent {
    docker { image 'node:latest' }
  }
  stages {
    stage('Test stage') {
      steps {
        sh 'node --version'
      }
    }
  }
}
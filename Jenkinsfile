pipeline {
    agent any
    stages {
        stage('build') {
            steps {
                bat """
					npm --version
					dir
					echo "Hi There!"
				"""
            }
        }
    }
}
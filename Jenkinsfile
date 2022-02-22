pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git 'https://github.com/Mike-Guidry/JenkinsTest.git'
            }
        }
        stage('Build') {
            steps {
                bat 'dotnet build -c Release'
            }
        }
        stage('Test') {
            steps {
                bat 'if exist "JenkinsAppTests/TestResults/" rmdir /s /q "JenkinsAppTests/TestResults"'
                bat 'dotnet test JenkinsAppTests/JenkinsAppTests.csproj --logger trx'
            }
            post {
                success {
                    mstest()
                }
            }
        }
        stage('Deploy Test') {
			when { branch 'development' }
            steps {
				echo 'deploy to test...'
            }
        }
		stage('Deploy Prod') {
			when { branch 'master' }
            steps {
				echo 'deploy to pro...'
            }
        }
    }
}

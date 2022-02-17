pipeline {
    agent any
    stages {
        stage('build') {

            //This is a comment
            steps {
                bat """
					echo "Line 1"
					dir
					echo "Hi There!"
				"""
				bat "npm --version"
		    
		bat "\"${env.MSBUILD}\" -t:restore"
		bat "\"${env.MSBUILD}\""
            }
        }
    }
}

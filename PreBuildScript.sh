# Exit immediately if a command fails
set -e

echo "Starting Git LFS setup for Unity Cloud Build..."

# Install git lfs (in case it's not installed)
git lfs install

# Pull down LFS-tracked files
git lfs pull

git lfs ls-files

echo "Git LFS setup completed successfully."